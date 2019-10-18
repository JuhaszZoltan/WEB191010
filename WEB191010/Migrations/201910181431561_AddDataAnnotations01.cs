namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations01 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ugyfels", "Nev", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ugyfels", "Nev", c => c.String());
        }
    }
}
