namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FelveszKedvencSzinAAppUserhez : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "KedvencSzin", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "KedvencSzin");
        }
    }
}
