using System.Collections.Generic;
using NeperiaDizionarioV2.Models;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NeperiaDizionarioV2.Models.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NeperiaDizionarioV2.Controllers
{
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ChartController(ApplicationDbContext context)
        {
            _context = context;

        }
        public ActionResult Index()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            var listaParoleTrovata = _context.ParolaTrovata.Include(p => p.Parola).Include(p => p.Elabor).ToList();
            var elaborLast = _context.Elabors.ToList().Last();
            var listaParola = _context.Parola.ToList();
            foreach (var ite in listaParoleTrovata)
            {
                if (ite.ElaborId == elaborLast.Id)
                    dataPoints.Add(new DataPoint(ite.Parola.Termo, ite.Count));
            }
            dataPoints2.Add(new DataPoint("Non Trovata", (listaParola.Count - dataPoints.Count)));
            dataPoints2.Add(new DataPoint("Trovata", (dataPoints.Count)));
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.ElaborName = JsonConvert.SerializeObject("Occorenzia di parole trovate Nel " + elaborLast.NameFile);
            
            return View();
        }
    }
}