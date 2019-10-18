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