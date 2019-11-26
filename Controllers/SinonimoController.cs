using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NeperiaDizionarioV2.Models;
using NeperiaDizionarioV2.Models.Data;

namespace NeperiaDizionarioV2.Controllers
{
    public class SinonimoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SinonimoController(ApplicationDbContext context)
        {

            _context = context;

        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var lista = _context.Sinonimi.Include(s => s.Parola);
            return View(await lista.ToListAsync());
        }
        public IActionResult Edit(int id)
        {
            var edit = _context.Sinonimi.Where(s => s.Id == id).FirstOrDefault();
            ViewData["ParolaId"] = new SelectList(_context.Parola, "Id", "Termo", edit.ParolaId);
            return View(edit);
        }
        public IActionResult New()
        {

            var newSinonimo = new Sinonimo();
            ViewData["ParolaId"] = new SelectList(_context.Parola, "Id", "Termo");
            return View(newSinonimo);
        }
        public IActionResult Delete(int id)
        {
            var delete = _context.Sinonimi.Where(p => p.Id == id).FirstOrDefault();
            return View(delete);
        }
        [HttpPost]
        public ActionResult Edit(Sinonimo sinonimo)
        {
            ViewData["ParolaId"] = new SelectList(_context.Parola, "Id", "Termo");

            if (ModelState.IsValid)
            {
                var editSinonimo = _context.Sinonimi.Find(sinonimo.Id);
                editSinonimo.Termo = sinonimo.Termo;
                editSinonimo.ParolaId = sinonimo.ParolaId;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(sinonimo);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(Sinonimo sinonimo)
        {
            var sinonimoSave = new Sinonimo()
            {
                Termo = sinonimo.Termo,

                ParolaId = sinonimo.ParolaId,
                Parola = null
            };
            if (ModelState.IsValid)
            {
                _context.Add(sinonimoSave);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(sinonimo);
            }
        }

        [HttpPost]
        public ActionResult Delete(Sinonimo sinonimo)
        {
            sinonimo.Parola = null;
            if (sinonimo == null)
            {
                return NotFound();
            }
            else
            {
                _context.Sinonimi.Remove(sinonimo);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}