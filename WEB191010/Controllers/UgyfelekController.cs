using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB191010.Models;

namespace WEB191010.Controllers
{
    public class UgyfelekController : Controller
    {
        // GET: Ugyfelek
        public ViewResult Index()
        {
            var ufk = GetData();
            return View(ufk);
        }

        public ActionResult Reszletek(int id)
        {
            var uf = GetData().SingleOrDefault(x => x.Id == id);

            if (uf is null) return HttpNotFound();
            else return View(uf);
        }

        private IEnumerable<Ugyfel> GetData()
        {
            return new List<Ugyfel>
            {
                new Ugyfel() { Id = 1, Nev = "Bogdán Barnabás"},
                new Ugyfel() { Id = 2, Nev = "Sándor Ramóna"},
                new Ugyfel() { Id = 3, Nev = "Szabó Ákos"},
                new Ugyfel() { Id = 4, Nev = "Bogdán Izabella"},
                new Ugyfel() { Id = 5, Nev = "Rácz Ábel"},
                new Ugyfel() { Id = 6, Nev = "Szűts Edina"},
                new Ugyfel() { Id = 7, Nev = "Király Gábor"},
                new Ugyfel() { Id = 8, Nev = "Oláh Kíra"},
            };
        }
    }
}