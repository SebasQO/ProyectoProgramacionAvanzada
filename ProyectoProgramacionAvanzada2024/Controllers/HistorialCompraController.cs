using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoProgramacionAvanzada2024.Models;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class HistorialCompraController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult ListaCompras()
        {
            var historialCompras = db.HistorialCompras.ToList();
            return View(historialCompras);
        }


        public ActionResult DetallesCompra(int id)
        {
            var historialCompra = db.HistorialCompras.Find(id);
            if (historialCompra == null)
            {
                return HttpNotFound();
            }
            return View(historialCompra);
        }


        public ActionResult CrearCompra()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCompra(HistorialCompra historialCompra)
        {
            if (ModelState.IsValid)
            {
                db.HistorialCompras.Add(historialCompra);
                db.SaveChanges();
                return RedirectToAction("ListaCompras");
            }
            return View(historialCompra);
        }


        public ActionResult EditarCompra(int id)
        {
            var historialCompra = db.HistorialCompras.Find(id);
            if (historialCompra == null)
            {
                return HttpNotFound();
            }
            return View(historialCompra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCompra(HistorialCompra historialCompra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historialCompra).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListaCompras");
            }
            return View(historialCompra);
        }


        public ActionResult EliminarCompra(int id)
        {
            var historialCompra = db.HistorialCompras.Find(id);
            if (historialCompra == null)
            {
                return HttpNotFound();
            }
            return View(historialCompra);
        }

        [HttpPost, ActionName("EliminarCompra")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarEliminarCompra(int id)
        {
            var historialCompra = db.HistorialCompras.Find(id);
            db.HistorialCompras.Remove(historialCompra);
            db.SaveChanges();
            return RedirectToAction("ListaCompras");
        }
    }
}