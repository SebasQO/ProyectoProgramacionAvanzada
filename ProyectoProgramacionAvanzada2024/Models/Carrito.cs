using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class Carrito
    {
        [Key]
        public int CarritoId { get; set; }
        public int CodigoCarrito { get; set; }
        public int CodigoUsuario { get; set; }
    }
}