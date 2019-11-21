namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmekUjra : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "MufajId", "dbo.Mufajs");
            DropIndex("dbo.Films", new[] { "MufajId" });
            AddColumn("dbo.Films", "Mufajok", c => c.String());
            DropColumn("dbo.Films", "MufajId");
            DropTable("dbo.Mufajs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Mufajs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Films", "MufajId", c => c.Int(nullable: false));
            DropColumn("dbo.Films", "Mufajok");
            CreateIndex("dbo.Films", "MufajId");
            AddForeignKey("dbo.Films", "MufajId", "dbo.Mufajs", "Id", cascadeDelete: true);
        }
    }
}
