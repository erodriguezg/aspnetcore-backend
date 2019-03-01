using FluentMigrator;
using System;

namespace AspNetCoreBackend.Migrations
{
    [Migration(001)]
    public class TablasInicialesMigration : Migration
    {
        public override void Up()
        {
            // Los Script se guardan /Migrations/Scripts y se deben marcar con la propiedad 'Build Action' : Embbeded Resource
            Execute.EmbeddedScript("M001_TablasIniciales_Up.sql");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
        
    }
}
