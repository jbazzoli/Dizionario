using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeperiaDizionarioV2.Models;
using NeperiaDizionarioV2.Models.Data;

namespace NeperiaDizionarioV2.Controllers
{
    public class ParolaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParolaController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var lista = _context.Parola.ToList();


            return View(lista);
        }
        public IActionResult Edit(int id)
        {
            var edit = _context.Parola.Where(p => p.Id == id).FirstOrDefault();
            return View(edit);
        }
        public IActionResult New()
        {
            var newParola = new Parola();
            return View(newParola);
        }
        public IActionResult Delete(int id)
        {
            var delete = _context.Parola.Where(p => p.Id == id).FirstOrDefault();
            return View(delete);
        }
        [HttpPost]
        public ActionResult Edit(Parola parola)
        {
            if (ModelState.IsValid)
            {
                var edit = _context.Parola.Find(parola.Id);
                edit.Termo = parola.Termo;
                edit.Peso = parola.Peso;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(parola);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(Parola parola)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parola);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(parola);
            }
        }

        [HttpPost]
        public ActionResult Delete(Parola parola)
        {

            if (parola == null)
            {
                return NotFound();
            }
            else
            {
                _context.Parola.Remove(parola);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}