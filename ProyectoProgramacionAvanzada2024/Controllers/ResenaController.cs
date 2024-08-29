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

        // Acción para listar todas las reseñas
        public ActionResult ListaResenas()
        {
            var resenas = db.Resenas.ToList();
            return View(resenas);
        }

        // Acción para ver los detalles de una reseña
        public ActionResult DetallesResena(int id)
        {
            var resena = db.Resenas.Find(id);
            if (resena == null)
            {
                return HttpNotFound();
            }
            return View(resena);
        }

        // GET: Acción para mostrar el formulario de crear una reseña
        public ActionResult CrearResena()
        {
            return View();
        }

        // POST: Acción para guardar la nueva reseña
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearResena(Resena resena)
        {
            if (ModelState.IsValid)
            {
                db.Resenas.Add(resena);
                db.SaveChanges();
                return RedirectToAction("ListaResenas");
            }
            return View(resena);
        }

        // GET: Acción para mostrar el formulario de editar una reseña
        public ActionResult EditarResena(int id)
        {
            var resena = db.Resenas.Find(id);
            if (resena == null)
            {
                return HttpNotFound();
            }
            return View(resena);
        }

        // POST: Acción para guardar los cambios en una reseña editada
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarResena(Resena resena)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resena).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(resena);
        }

        // GET: Acción para mostrar el formulario de confirmación de eliminación
        public ActionResult EliminarResena(int id)
        {
            var resena = db.Resenas.Find(id);
            if (resena == null)
            {
                return HttpNotFound();
            }
            return View(resena);
        }

        // POST: Acción para eliminar una reseña
        [HttpPost, ActionName("EliminarResena")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarResenaoConfirmed(int id)
        {
            var resena = db.Resenas.Find(id);
            if (resena != null)
            {
                db.Resenas.Remove(resena);
                db.SaveChanges();
            }
            return RedirectToAction("ListaResenas");
        }
    }
}