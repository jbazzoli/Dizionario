using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using NeperiaDizionarioV2.Models;
using NeperiaDizionarioV2.Models.Data;

namespace NeperiaDizionarioV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileProvider fileProvider;

        public HomeController(IFileProvider fileProvider, ApplicationDbContext context)
        {
            _context = context;
            this.fileProvider = fileProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewBag.Error = "Archivo non selezionato o non supportato";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {

            if (file == null || file.Length == 0 || file.GetFilename().Split('.')[1] != "docx")
            {

                return RedirectToAction("Error");
            }


            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "Archivi",
                        file.GetFilename());

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            try
            {

                using (var doc = WordprocessingDocument.Open(path, false))
                {
                    Elabor elaborazione = new Elabor()
                    {
                        NameFile = file.FileName,
                        DataStart = DateTime.Now,
                        Count = 0,
                        Weight = 0
                    };
                    _context.Add(elaborazione);
                    _context.SaveChanges();
                    var elaborazioneContext = _context.Elabors.ToList().Last();
                    foreach (var el in doc.MainDocumentPart.Document.Body.Elements().OfType<Paragraph>())
                    {
                        var listOfWords = el.InnerText.Split(' ');

                        foreach (var itenList in listOfWords)
                        {
                            var parola = _context.Parola.Where(p => p.Termo.ToUpper().Equals(itenList.ToUpper()) == true).FirstOrDefault();
                            if (parola == null)
                            {
                                var sinonimo = _context.Sinonimi.Where(s => s.Termo.ToUpper().Equals(itenList.ToUpper()) == true).FirstOrDefault();
                                if (sinonimo != null)
                                {
                                    elaborazioneContext.Count += 1;
                                    elaborazioneContext.Weight += _context.Parola.Where(p => p.Id == sinonimo.ParolaId).FirstOrDefault().Peso;
                                    var parolaTrovata = _context.ParolaTrovata.Where(p => p.ParolaId == sinonimo.ParolaId && p.ElaborId == elaborazioneContext.Id).FirstOrDefault();
                                    if (parolaTrovata != null)
                                    {
                                        parolaTrovata.Count += 1;
                                    }
                                    else
                                    {
                                        var newparalaTrovata = new ParolaTrovata()
                                        {
                                            ParolaId = sinonimo.ParolaId,
                                            ElaborId = elaborazioneContext.Id,
                                            Count = 1
                                        };
                                        _context.Add(newparalaTrovata);

                                    }

                                }
                            }
                            else
                            {

                                if (parola != null)
                                {
                                    elaborazioneContext.Count += 1;
                                    elaborazioneContext.Weight += parola.Peso;
                                    var parolaTrovata = _context.ParolaTrovata.Where(p => p.ParolaId == parola.Id && elaborazioneContext.Id == p.ElaborId).FirstOrDefault();
                                    if (parolaTrovata != null)
                                    {
                                        parolaTrovata.Count += 1;
                                    }
                                    else
                                    {
                                        var newparalaTrovata = new ParolaTrovata()
                                        {
                                            ParolaId = parola.Id,
                                            ElaborId = elaborazioneContext.Id,
                                            Count = 1
                                        };
                                        _context.Add(newparalaTrovata);

                                    }
                                }

                            }
                            _context.SaveChanges();
                        }


                    }

                }

            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            return RedirectToAction("Files");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return Content("files not selected");

            foreach (var file in files)
            {
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "Archivi",
                        file.GetFilename());

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return RedirectToAction("Files");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFileViaModel(FileInputModel model)
        {
            if (model == null ||
                model.FileToUpload == null || model.FileToUpload.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "Archivi",
                        model.FileToUpload.GetFilename());

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.FileToUpload.CopyToAsync(stream);
            }

            return RedirectToAction("Files");
        }

        public IActionResult Files()
        {
            var ListaElaborazioni = _context.Elabors.ToList();
            return View(ListaElaborazioni);
        }

        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "Archivi", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}
