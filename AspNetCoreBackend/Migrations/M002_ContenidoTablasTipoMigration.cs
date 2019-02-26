using FluentMigrator;

namespace AspNetCoreBackend.Migrations
{
    [Migration(002)]
    public class ContenidoTablasTipoMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M002_ContenidoTablasTipo_Up.sql");
        }

        public override void Down()
        {
            Execute.EmbeddedScript("M002_ContenidoTablasTipo_Down.sql");
        }

        
    }
}
