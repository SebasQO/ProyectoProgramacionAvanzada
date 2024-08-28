using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class ProductoPedido
    {
        [Key]
        public int ProductoPedidoId { get; set; }
        public int CodigoPedido { get; set; }
        public int CodigoProducto { get; set; }
    }
}