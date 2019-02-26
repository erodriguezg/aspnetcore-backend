using FluentMigrator;

namespace AspNetCoreBackend.Migrations
{
    [Migration(1)]
    public class TablasInicialesMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M001_TablasIniciales_Up.sql");
        }

        public override void Down()
        {
            Execute.EmbeddedScript("M001_TablasIniciales_Down.sql");
        }

        
    }
}
