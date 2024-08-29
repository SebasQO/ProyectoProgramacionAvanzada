using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class CarritoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        public ActionResult ListaCarritos()
        {
            var model = db.Carritos.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult CrearCarrito()
        {
            return View();
        }

        public ActionResult CrearCarrito(Carrito cart)
        {
            if (ModelState.IsValid)
            {
                db.Carritos.Add(cart);
                db.SaveChanges();
                return RedirectToAction("CartList");
            }
            return View(cart);
        }

        public ActionResult DetallesCarrito(int id)
        {
            var cart = db.Carritos.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        public ActionResult EditarCarrito(int? id)
        {
            var cart = db.Carritos.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCarrito(Carrito cart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CartList");
            }
            return View(cart);
        }

        [HttpGet]
        public ActionResult EliminarCarrito(int id)
        {
            var cart = db.Carritos.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        [HttpPost, ActionName("EliminarCarrito")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarProductoConfirmed(int id)
        {
            var cart = db.Carritos.Find(id);
            if (cart != null)
            {
                db.Carritos.Remove(cart);
                db.SaveChanges();
            }
            return RedirectToAction("CartList");
        }

        [HttpGet]
        public ActionResult CartView()
        {
            return View();
        }

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