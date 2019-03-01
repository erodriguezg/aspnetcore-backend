using FluentMigrator;
using System;

namespace AspNetCoreBackend.Migrations
{
    [Migration(003)]
    public class RegionesProvinciasComunasMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M003_RegionesProvinciasComunas_Up.sql");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
        
    }
}
