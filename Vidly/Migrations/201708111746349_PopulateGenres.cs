namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Name) values ('Action')");
            Sql("insert into Genres (Name) values ('Horror')");
            Sql("insert into Genres (Name) values ('Drama')");
            Sql("insert into Genres (Name) values ('Romance')");
            Sql("insert into Genres (Name) values ('Documentary')");
            Sql("insert into Genres (Name) values ('Sci-fi')");
            Sql("insert into Genres (Name) values ('Thriller')");
            Sql("insert into Genres (Name) values ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
