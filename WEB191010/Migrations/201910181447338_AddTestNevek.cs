namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestNevek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Juhász Zoltán', 1, 1);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Lakatos Nintendo', 0, 2);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Cserepes Virag', 1, 2);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Varga Alehandró', 0, 3);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Mohamed Lee', 0, 3);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Kevin Koszner', 1, 4);");
        }
        
        public override void Down()
        {
        }
    }
}
