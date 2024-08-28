using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class ProductoCarrito
    {
        [Key]
        public int ProductoCarritoId { get; set; }
        public int CodigoCarrito { get; set; }
        public int CodigoProducto { get; set; }
    }
}