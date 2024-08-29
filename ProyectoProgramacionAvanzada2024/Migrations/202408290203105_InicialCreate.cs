namespace ProyectoProgramacionAvanzada2024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialCreate : DbMigration
    {
        public override void Up()
        {
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
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
