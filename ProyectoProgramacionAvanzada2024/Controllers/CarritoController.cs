using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class CarritoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult CartView()
        {
            return View();
        }

        // Agregar producto al carrito
        [HttpPost]
        public ActionResult AddToCart(int codigoProducto)
        {
            var usuario = Session["User"] as Usuario;
            if (usuario != null)
            {
                var carrito = db.Carritos.SingleOrDefault(c => c.CodigoUsuario == usuario.CodigoUsuario);
                if (carrito == null)
                {
                    carrito = new Carrito { CodigoUsuario = usuario.CodigoUsuario };
                    db.Carritos.Add(carrito);
                    db.SaveChanges();
                }

                db.ProductosCarrito.Add(new ProductoCarrito { CodigoCarrito = carrito.CodigoCarrito, CodigoProducto = codigoProducto });
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // Ver carrito
        public ActionResult ViewCart()
        {
            var usuario = Session["User"] as Usuario;
            if (usuario != null)
            {
                var carrito = db.Carritos.SingleOrDefault(c => c.CodigoUsuario == usuario.CodigoUsuario);
                if (carrito != null)
                {
                    var productos = db.ProductosCarrito.Where(pc => pc.CodigoCarrito == carrito.CodigoCarrito)
                        .Select(pc => db.Productos.Find(pc.CodigoProducto)).ToList();
                    return View(productos);
                }
            }
            return RedirectToAction("Index");
        }
    }
}