namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEFNevek : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ElofizetesTipus SET Nev = 'Nincs' WHERE Id = 1");
            Sql("UPDATE ElofizetesTipus SET Nev = 'Havi' WHERE Id = 2");
            Sql("UPDATE ElofizetesTipus SET Nev = 'Negyedéves' WHERE Id = 3");
            Sql("UPDATE ElofizetesTipus SET Nev = 'Éves' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
