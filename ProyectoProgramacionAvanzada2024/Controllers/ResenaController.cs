using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class ResenaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        public ActionResult AddReview(Resena resena)
        {
            var usuario = Session["User"] as Usuario;
            if (usuario != null)
            {
                resena.CodigoUsuario = usuario.CodigoUsuario;
                db.Resenas.Add(resena);
                db.SaveChanges();
            }
            return RedirectToAction("ProductDetails", new { id = resena.CodigoProducto });
        }
    }
}