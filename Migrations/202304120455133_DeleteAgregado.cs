namespace Vuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAgregado : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vueloes", "Nombre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vueloes", "LineaAerea", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vueloes", "LineaAerea", c => c.String(maxLength: 255));
            AlterColumn("dbo.Vueloes", "Nombre", c => c.String(maxLength: 255));
        }
    }
}
