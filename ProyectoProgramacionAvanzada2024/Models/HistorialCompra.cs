using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class HistorialCompra
    {
        [Key]
        public int Id { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}