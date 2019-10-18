namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUgyfelSzulDatum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ugyfels", "SzuletesiDatum", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ugyfels", "SzuletesiDatum");
        }
    }
}
