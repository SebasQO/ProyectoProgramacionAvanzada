using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class PedidoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult ListaPedido()
        {
            var model = db.Pedidos.ToList();
            return View(model);
        }

        public ActionResult OrderHistory()
        {
            var usuario = Session["User"] as Usuario;
            if (usuario != null)
            {
                var pedidos = db.Pedidos.Where(p => p.CodigoUsuario == usuario.CodigoUsuario).ToList();
                return View(pedidos);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult OrderHistoryView()
        {
            return View();
        }

        public ActionResult Detalles(int id)
        {
            var pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View("DetallesPedido", pedido); // Asegúrate de que el nombre coincida
        }

        [HttpGet]
        public ActionResult EditarPedido(int id)
        {
            var pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPedido(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListaPedido", new { id = pedido.CodigoPedido });
            }
            return View(pedido);
        }

        [HttpGet]
        public ActionResult EliminarPedido(int id)
        {
            var pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        [HttpPost, ActionName("EliminarPedido")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarPedidoConfirmed(int id)
        {
            var pedido = db.Pedidos.Find(id);
            if (pedido != null)
            {
                db.Pedidos.Remove(pedido);
                db.SaveChanges();
            }
            return RedirectToAction("ListaPedido");
        }
    }
}