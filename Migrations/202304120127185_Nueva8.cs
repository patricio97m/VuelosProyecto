namespace Vuelos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Nueva8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Vueloes",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 255),
                        HorarioDeLLegada = c.DateTime(nullable: false),
                        LineaAerea = c.String(maxLength: 255),
                        Demorado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
        }
    }
}
