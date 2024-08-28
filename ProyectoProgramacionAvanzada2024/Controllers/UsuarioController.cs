using ProyectoProgramacionAvanzada2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgramacionAvanzada2024.Controllers
{
    public class UsuarioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // Registro de usuario
        [HttpPost]
        public ActionResult Register(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    usuario.UltimaConexion = DateTime.Now;
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();

                    return RedirectToAction("Login", "Usuario");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                }
            }
            return View(usuario);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // Autenticación
        [HttpPost]
        public ActionResult Login(string nombreUsuario, string contrasena)
        {
            var user = db.Usuarios.SingleOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contrasena == contrasena);
            if (user != null)
            {
                Session["User"] = user;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}