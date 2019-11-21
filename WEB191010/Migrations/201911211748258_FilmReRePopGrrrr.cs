namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmReRePopGrrrr : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Films WHERE 0 = 0");

            Sql("INSERT INTO Films (Cim, MegjelenesDatum, BeszerzesDatum, KeszletDb, ImgReference, MufajokDbCol) VALUES " +
                $"('Matrix', '1999-08-05', '{DateTime.Now.ToString("yyyy-MM-dd")}', 11, 'matrix01.png', 'Action, Sci-Fi')," +
                $"('Kill Bill', '2003-10-16', '{DateTime.Now.ToString("yyyy-MM-dd")}', 6, 'killbill01.png', 'Action, Crime, Thriller')");

        }

        public override void Down()
        {
        }
    }
}
