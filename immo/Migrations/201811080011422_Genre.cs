namespace immo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Annonces", "genre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Annonces", "genre");
        }
    }
}
