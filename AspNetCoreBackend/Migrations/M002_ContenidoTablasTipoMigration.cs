using FluentMigrator;
using System;

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
            throw new NotImplementedException();
        }
        
    }
}
