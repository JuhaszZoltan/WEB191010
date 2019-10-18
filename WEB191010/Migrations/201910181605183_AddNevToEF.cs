namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNevToEF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cim = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ElofizetesTipus", "Nev", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ElofizetesTipus", "Nev");
            DropTable("dbo.Films");
        }
    }
}
