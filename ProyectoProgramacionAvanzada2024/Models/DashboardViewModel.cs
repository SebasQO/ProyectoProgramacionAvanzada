using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class DashboardViewModel
    {
        public int TotalUs { get; set; }
        public int TotalUsuarios { get; set; }
        public int TotalProductos { get; set; }
        public int TotalClientes { get; set; }
        public int TotalPedidosRecientes { get; set; }
        public int TotalReseñasPendientes { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}