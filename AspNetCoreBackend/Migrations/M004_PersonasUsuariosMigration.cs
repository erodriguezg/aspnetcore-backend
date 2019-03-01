using FluentMigrator;
using System;

namespace AspNetCoreBackend.Migrations
{
    [Migration(004)]
    public class PersonasUsuariosMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M004_PersonasUsuarios_Up.sql");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
        
    }
}
