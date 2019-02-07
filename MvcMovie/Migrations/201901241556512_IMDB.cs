namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IMDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IMDB", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Cartell", c => c.String());
            AddColumn("dbo.Movies", "Durada", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Durada");
            DropColumn("dbo.Movies", "Cartell");
            DropColumn("dbo.Movies", "IMDB");
        }
    }
}
