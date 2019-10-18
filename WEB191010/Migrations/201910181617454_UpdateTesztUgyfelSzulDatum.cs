namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTesztUgyfelSzulDatum : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Ugyfels SET SzuletesiDatum = '1990-07-11' WHERE Id = 2");
            Sql("UPDATE Ugyfels SET SzuletesiDatum = '2000-05-24' WHERE Id = 4");
            Sql("UPDATE Ugyfels SET SzuletesiDatum = '1987-12-01' WHERE Id = 6");
        }
        
        public override void Down()
        {
        }
    }
}
