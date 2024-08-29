using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class ClienteController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult ListaClientes()
        {
            var model = db.Clientes.ToList();
            return View(model);
        }


        [HttpGet]
        public ActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("ListaClientes");
            }
            return View(cliente);
        }


        public ActionResult DetallesCliente(int id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }


        [HttpGet]
        public ActionResult EditarCliente(int? id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListaClientes", new { id = cliente.ClienteId });
            }
            return View(cliente);
        }


        [HttpGet]
        public ActionResult EliminarCliente(int id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("EliminarCliente")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarClienteConfirmed(int id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
            return RedirectToAction("ListaClientes");
        }
    }
}