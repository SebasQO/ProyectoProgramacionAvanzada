using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class PedidoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

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

        public ActionResult Index()
        {
            var pedidos = db.Pedidos.ToList();
            return View(pedidos);
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
    }
}