namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ujFilmek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Films (Cim, MegjelenesDatum, BeszerzesDatum, KeszletDb, ImgReference, MufajokDbCol) VALUES " +
                $"('Cloud Atlas', '2012-11-22', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'cloud_atlas.jpg', 'Action, Drama, Mystery')," +
                $"('The Lazarus Project', '2008-10-24', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'lazarus.jpg', 'Drama, Mystery, Thriller')," +
                $"('Predestination', '2014-08-28', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'predes.jpg', 'Action, Drama, Mystery')," +
                $"('Joker', '2019-10-03', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'joker.jpg', 'Crime, Drama, Thriller')," +
                $"('Donnie Darko', '2003-05-22', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'donnie.jpg', 'Drama, Sci-Fi, Thriller')," +
                $"('Moon', '2009-12-31', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'moon.jpg', 'Drama, Mystery, Sci-Fi')," +
                $"('Fight Club', '2000-01-27', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'fight_club.jpg', 'Drama')," +
                $"('The Hateful Eight', '2016-01-07', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'hateful.jpg', 'Crime, Drama, Mystery')," +
                $"('Twelve Monkeys', '1996-05-09', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{new Random().Next(10, 20)}', 'monkey12.jpg', 'Mystery, Sci-Fi, Thriller')");

        }

        public override void Down()
        {
        }
    }
}
