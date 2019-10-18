namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEfid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ugyfels", "ElofizetesTipus_Id", "dbo.ElofizetesTipus");
            DropIndex("dbo.Ugyfels", new[] { "ElofizetesTipus_Id" });
            RenameColumn(table: "dbo.Ugyfels", name: "ElofizetesTipus_Id", newName: "ElofizetesTipusId");
            AlterColumn("dbo.Ugyfels", "ElofizetesTipusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ugyfels", "ElofizetesTipusId");
            AddForeignKey("dbo.Ugyfels", "ElofizetesTipusId", "dbo.ElofizetesTipus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ugyfels", "ElofizetesTipusId", "dbo.ElofizetesTipus");
            DropIndex("dbo.Ugyfels", new[] { "ElofizetesTipusId" });
            AlterColumn("dbo.Ugyfels", "ElofizetesTipusId", c => c.Int());
            RenameColumn(table: "dbo.Ugyfels", name: "ElofizetesTipusId", newName: "ElofizetesTipus_Id");
            CreateIndex("dbo.Ugyfels", "ElofizetesTipus_Id");
            AddForeignKey("dbo.Ugyfels", "ElofizetesTipus_Id", "dbo.ElofizetesTipus", "Id");
        }
    }
}
