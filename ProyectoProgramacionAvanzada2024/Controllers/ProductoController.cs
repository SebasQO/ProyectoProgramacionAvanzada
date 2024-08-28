using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class ProductoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult ListaProductos()
        {
            var model = db.Productos.ToList();
            return View(model);
        }


        [HttpGet]
        public ActionResult CrearProducto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("ListaProductos");
            }
            return View(producto);
        }


        public ActionResult DetallesProducto(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }


        [HttpGet]
        public ActionResult EditarProducto(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListaProductos", new { id = producto.CodigoProducto });
            }
            return View(producto);
        }


        [HttpGet]
        public ActionResult EliminarProducto(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        [HttpPost, ActionName("EliminarProducto")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarProductoConfirmed(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto != null)
            {
                db.Productos.Remove(producto);
                db.SaveChanges();
            }
            return RedirectToAction("ListaProductos");
        }

        [HttpGet]
        public ActionResult CartView()
        {
            return View();
        }
    }
}