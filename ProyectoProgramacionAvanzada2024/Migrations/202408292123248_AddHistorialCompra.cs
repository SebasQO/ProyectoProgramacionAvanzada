namespace ProyectoProgramacionAvanzada2024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHistorialCompra : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HistorialCompras");
        }
    }
}
