namespace ProyectoProgramacionAvanzada2024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialCreateMejorasCRUDPedidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carritoes",
                c => new
                    {
                        CarritoId = c.Int(nullable: false, identity: true),
                        CodigoCarrito = c.Int(nullable: false),
                        CodigoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarritoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Correo = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false),
                        Direccion = c.String(maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.HistorialCompras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoUsuario = c.Int(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                        FechaCompra = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        CodigoPedido = c.Int(nullable: false, identity: true),
                        CodigoUsuario = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoPedido);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        CodigoProducto = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponibilidad = c.Boolean(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoProducto);
            
            CreateTable(
                "dbo.ProductoCarritoes",
                c => new
                    {
                        ProductoCarritoId = c.Int(nullable: false, identity: true),
                        CodigoCarrito = c.Int(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoCarritoId);
            
            CreateTable(
                "dbo.ProductoPedidoes",
                c => new
                    {
                        ProductoPedidoId = c.Int(nullable: false, identity: true),
                        CodigoPedido = c.Int(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoPedidoId);
            
            CreateTable(
                "dbo.Resenas",
                c => new
                    {
                        CodigoResena = c.Int(nullable: false, identity: true),
                        CodigoProducto = c.Int(nullable: false),
                        CodigoUsuario = c.Int(nullable: false),
                        Comentario = c.String(),
                        Calificacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoResena);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        CodigoUsuario = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(),
                        Contrasena = c.String(),
                        UltimaConexion = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Resenas");
            DropTable("dbo.ProductoPedidoes");
            DropTable("dbo.ProductoCarritoes");
            DropTable("dbo.Productoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.HistorialCompras");
            DropTable("dbo.Clientes");
            DropTable("dbo.Carritoes");
        }
    }
}
