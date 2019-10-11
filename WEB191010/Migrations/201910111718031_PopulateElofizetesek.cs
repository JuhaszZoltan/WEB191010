namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateElofizetesek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ElofizetesTipus (Dij, Kedvezmeny, IdotartamHonap) VALUES (0, 0, 0)");
            Sql("INSERT INTO ElofizetesTipus (Dij, Kedvezmeny, IdotartamHonap) VALUES (3000, 10, 1)");
            Sql("INSERT INTO ElofizetesTipus (Dij, Kedvezmeny, IdotartamHonap) VALUES (8000, 15, 3)");
            Sql("INSERT INTO ElofizetesTipus (Dij, Kedvezmeny, IdotartamHonap) VALUES (30000, 20, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
