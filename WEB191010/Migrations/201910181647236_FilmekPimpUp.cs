namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmekPimpUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mufajs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Films", "MegjelenesDatum", c => c.DateTime(nullable: false));
            AddColumn("dbo.Films", "BeszerzesDatum", c => c.DateTime(nullable: false));
            AddColumn("dbo.Films", "KeszletDb", c => c.Int(nullable: false));
            AddColumn("dbo.Films", "ImgReference", c => c.String());
            AddColumn("dbo.Films", "MufajId", c => c.Int(nullable: false));
            CreateIndex("dbo.Films", "MufajId");
            AddForeignKey("dbo.Films", "MufajId", "dbo.Mufajs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "MufajId", "dbo.Mufajs");
            DropIndex("dbo.Films", new[] { "MufajId" });
            DropColumn("dbo.Films", "MufajId");
            DropColumn("dbo.Films", "ImgReference");
            DropColumn("dbo.Films", "KeszletDb");
            DropColumn("dbo.Films", "BeszerzesDatum");
            DropColumn("dbo.Films", "MegjelenesDatum");
            DropTable("dbo.Mufajs");
        }
    }
}
