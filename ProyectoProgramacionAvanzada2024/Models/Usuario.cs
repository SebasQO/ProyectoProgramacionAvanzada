using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class Usuario
    {
        [Key]
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime UltimaConexion { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
    }
}