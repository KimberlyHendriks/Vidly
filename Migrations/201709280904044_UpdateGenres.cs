namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Comedy')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Sci-fi')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Drama')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Documentary')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Family')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Horror')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Thriller')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('RomCom')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Romantic')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Adventure')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Fiction')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Neo-Noir')");
            Sql("INSERT INTO Genres(MovieGenre) VALUES ('Silent')");
        }
        
        public override void Down()
        {
        }
    }
}
