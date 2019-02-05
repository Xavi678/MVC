namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Titol", c => c.String());
            AddColumn("dbo.Movies", "DataEstrena", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Genere", c => c.String());
            AddColumn("dbo.Movies", "Preu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Sinopsi", c => c.String());
            DropColumn("dbo.Movies", "Title");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Title", c => c.String());
            DropColumn("dbo.Movies", "Sinopsi");
            DropColumn("dbo.Movies", "Preu");
            DropColumn("dbo.Movies", "Genere");
            DropColumn("dbo.Movies", "DataEstrena");
            DropColumn("dbo.Movies", "Titol");
        }
    }
}
