namespace Financas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimentacaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Tipo = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: false),
                        Nome = c.String(nullable: false),
                        Email = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentacaos", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Movimentacaos", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Movimentacaos");
        }
    }
}
