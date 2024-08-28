using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoProgramacionAvanzada2024.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Resena> Resenas { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProductoCarrito> ProductosCarrito { get; set; }
        public DbSet<ProductoPedido> ProductosPedido { get; set; }
    }
}