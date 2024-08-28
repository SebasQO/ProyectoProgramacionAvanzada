using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class Resena
    {
        [Key]
        public int CodigoResena { get; set; }
        public int CodigoProducto { get; set; }
        public int CodigoUsuario { get; set; }
        public string Comentario { get; set; }
        public int Calificacion { get; set; }
    }
}