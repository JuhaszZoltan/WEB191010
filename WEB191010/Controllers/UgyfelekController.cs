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

        public UgyfelekController() => _context = new ApplicationDbContext();

        [Authorize(Roles = RoleNevek.Admin)]
        public ActionResult Uj()
        {
            var vm = new UgyfelFormViewModel()
            {
                Ugyfel = new Ugyfel(),
                ElofizetesTipusok = _context.Elofizetesek.ToList()
            };

            return View("UgyfelForm", vm);
        }

        [Authorize(Roles = RoleNevek.Admin)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Mentes(Ugyfel ugyfel)
        {
            if (!ModelState.IsValid)
            {
                var vm = new UgyfelFormViewModel
                {
                    Ugyfel = ugyfel,
                    ElofizetesTipusok = _context.Elofizetesek.ToList()
                };

                return View("UgyfelForm", vm);
            }


            if (ugyfel.Id == 0)
            {
                _context.Ugyfelek.Add(ugyfel);
            }
            else
            {
                var letezoUgyfel = 
                    _context.Ugyfelek.Single(u => u.Id == ugyfel.Id);

                //Microsofték így csinálnák, de ez annyira nem nyerő
                //TryUpdateModel(letezoUgyfel);

                letezoUgyfel.Nev = ugyfel.Nev;
                letezoUgyfel.SzuletesiDatum = ugyfel.SzuletesiDatum;
                letezoUgyfel.HirlevelFeliratkozas = ugyfel.HirlevelFeliratkozas;
                letezoUgyfel.ElofizetesTipusId = ugyfel.ElofizetesTipusId;

                //ezt meg ha nem akarja valaki kézzel csinálni, használhat AutoMapper-t
                //https://automapper.org/
                //akkor kb így nézne ki: Mapper.Map(ugyfel, letezoUgyfel);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Ugyfelek");
        }

        [Authorize(Roles = RoleNevek.Admin)]
        public ActionResult Szerkesztes(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);
            if (ugyfel == null) return HttpNotFound();

            var vm = new UgyfelFormViewModel()
            {
                ElofizetesTipusok = _context.Elofizetesek.ToList(),
                Ugyfel = ugyfel
                
            };

            return View("UgyfelForm", vm);
        }
        protected override void Dispose(bool disposing) => _context.Dispose();    

        public ViewResult Index()
        {
            var ufk = _context.Ugyfelek.Include(u => u.ElofizetesTipus).ToList();
            if (User.IsInRole(RoleNevek.Admin))
                return View("AdminIndex", ufk);

            return View("VendegIndex", ufk);
        }

        [Authorize(Roles = RoleNevek.Admin)]
        public ActionResult Reszletek(int id)
        {
            var uf = _context.Ugyfelek.Include(u => u.ElofizetesTipus).SingleOrDefault(x => x.Id == id);

            if (uf is null) return HttpNotFound();
            else return View(uf);
        }
    }
}