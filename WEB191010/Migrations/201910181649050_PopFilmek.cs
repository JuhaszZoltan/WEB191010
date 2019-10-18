namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopFilmek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Mufajs (Nev) VALUES " +
                "('Akci�'),('Anim�ci�'),('B�n�gyi')," +
                "('Csal�di'),('Dokumentum'),('Erotikus')," +
                "('Fantasy'),('Dr�ma'),('V�gj�t�k')," +
                "('Katasztr�fa'),('Misztikus'),('Koncert')," +
                "('Romantikus'),('Sci-fi'),('Thriller')," +
                "('H�bor�s'),('Horror'),('Kaland');");

            Sql("INSERT INTO Films (Cim, MegjelenesDatum, BeszerzesDatum, KeszletDb, ImgReference, MufajId) VALUES " +
                $"('Matrix', '1999-08-05', '{DateTime.Now.ToString("yyyy-MM-dd")}', 11, 'matrix01.png', 14)," +
                $"('Kill Bill', '2003-10-16', '{DateTime.Now.ToString("yyyy-MM-dd")}', 6, 'killbill01.png', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
