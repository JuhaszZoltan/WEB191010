using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB191010.Models;

namespace WEB191010.Controllers
{
    public class FilmekController : Controller
    {
        readonly ApplicationDbContext _context;

        public FilmekController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var flms = _context.Filmek.Include(f => f.Mufaj).ToList();
            return View(flms);
        }

        #region faszsagok
        //private IEnumerable<Film> GetData()
        //{
        //    return new List<Film>
        //    {
        //        new Film(){ Id = 1, Cim = "Matrix" },
        //        new Film(){ Id = 2, Cim = "Terminator" },
        //        new Film(){ Id = 3, Cim = "Cloud Atlas" },
        //        new Film(){ Id = 4, Cim = "True Love" },
        //        new Film(){ Id = 5, Cim = "Kill Bill" },
        //    };
        //}

        //public ViewResult Random()
        //{
        //    var film = new Film()
        //    {
        //        Cim = "Kill Bill"
        //    };

        //    var kolcsonzok = new List<Ugyfel>()
        //    {
        //        new Ugyfel() { Nev = "Géza" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Lacika" },
        //        new Ugyfel() { Nev = "Zsuzsanna" }
        //    };

        //    var rfvm = new RandomFilmViewModel()
        //    {
        //        Film = film,
        //        Kolcsonzok = kolcsonzok
        //    };

        //    return View(rfvm);
        //}

        //#region lehetséges ViewResult visszatérési típusok
        ////return Content("szeretem a cicákat! <3");
        ////return HttpNotFound();
        ////return RedirectToAction("Index", "Home", new { oldal = 1, rendezes = "cim" });

        ////ViewData["Film"] = film;
        ////ViewBag.Film = film;
        //#endregion

        //public ActionResult Szerkesztes(int id)
        //{
        //    return Content($"id = {id}");
        //}

        //#region alapértelmezett értékek
        ////xyz.hu/Filmek/oldal/rendezes
        ////xyz.hu/Filmek/2/ev
        ////xyz.hu/Filmek  -> //xyz.hu/Filmek/1/cim

        ////public ActionResult Index(int oldal = 1, string rendezes = "cim")
        ////{
        ////    //if (!oldal.HasValue) oldal = 1;
        ////    //if (string.IsNullOrWhiteSpace(rendezes)) rendezes = "cim";

        ////    return Content($"oldalszám: {oldal} | rendezés: {rendezes}");
        ////}
        //#endregion

        ////attribute routing
        //[Route("Filmek/Megjelenes/{ev:regex(\\d{4})}/{honap:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult Megjelenes(int ev, int honap)
        //{
        //    return Content($"év = {ev} | hónap = {honap}");
        //}
        //// /filmek/megjelenes/2015/02
        #endregion
    }
}