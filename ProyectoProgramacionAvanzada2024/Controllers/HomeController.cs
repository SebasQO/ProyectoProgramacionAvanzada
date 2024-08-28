using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = new DashboardViewModel
            {
                TotalUsuarios = db.Usuarios.Count(),
                TotalProductos = db.Productos.Count(),
                TotalReseñasPendientes = db.Resenas.Count(),
                TotalPedidosRecientes = db.Pedidos.Count(),
                Pedidos = db.Pedidos.ToList()
            };
            return View(model);
        }
    }
}