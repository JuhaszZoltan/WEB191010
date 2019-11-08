using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB191010.Models;

namespace WEB191010.Controllers
{
    public class UgyfelekController : Controller
    {
        // GET: Ugyfelek
        readonly ApplicationDbContext _context;

        public UgyfelekController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Uj()
        {
            var vm = new UjUgyfelViewModel()
            {
                ElofizetesTipusok = _context.Elofizetesek.ToList()
            };

            return View("UgyfelForm", vm);
        }
        [HttpPost]
        public ActionResult Mentes(Ugyfel ugyfel)
        {
            if (ugyfel.Id == 0)
            {
                _context.Ugyfelek.Add(ugyfel);
            }
            else
            {
                var letezoUgyfel = 
                    _context.Ugyfelek.SingleOrDefault(u => u.Id == ugyfel.Id);

                letezoUgyfel.Nev = ugyfel.Nev;
                letezoUgyfel.SzuletesiDatum = ugyfel.SzuletesiDatum;
                letezoUgyfel.HirlevelFeliratkozas = ugyfel.HirlevelFeliratkozas;
                letezoUgyfel.ElofizetesTipusId = ugyfel.ElofizetesTipusId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Ugyfelek");
        }

        public ActionResult Szerkesztes(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfel == null) return HttpNotFound();

            var vm = new UjUgyfelViewModel()
            {
                ElofizetesTipusok = _context.Elofizetesek.ToList(),
                Ugyfel = ugyfel
                
            };

            return View("UgyfelForm", vm);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }



        public ViewResult Index()
        {
            var ufk = _context.Ugyfelek.Include(u => u.ElofizetesTipus).ToList();
            return View(ufk);
        }

        public ActionResult Reszletek(int id)
        {
            var uf = _context.Ugyfelek.Include(u => u.ElofizetesTipus).SingleOrDefault(x => x.Id == id);

            if (uf is null) return HttpNotFound();
            else return View(uf);
        }
    }
}