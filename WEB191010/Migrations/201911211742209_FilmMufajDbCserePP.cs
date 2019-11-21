namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmMufajDbCserePP : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "MufajokDbCol", c => c.String());
            DropColumn("dbo.Films", "Mufajok");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Mufajok", c => c.String());
            DropColumn("dbo.Films", "MufajokDbCol");
        }
    }
}
