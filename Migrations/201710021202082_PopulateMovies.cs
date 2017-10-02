namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumbersInStock, Genre_Id) VALUES ('Interstellar', 23-9-2015, 26-8-2016, 5, 12)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumbersInStock, Genre_Id) VALUES ('Guardians of the Galaxy', 12-2-2014, 3-6-2014, 1, 11)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumbersInStock, Genre_Id) VALUES ('Dod Sno', 2-7-2002, 4-1-2009, 6, 11)");

        }

        public override void Down()
        {
        }
    }
}
