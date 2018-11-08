namespace immo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Annonces",
                c => new
                    {
                        AnnonceID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Category_idCat = c.Int(),
                    })
                .PrimaryKey(t => t.AnnonceID)
                .ForeignKey("dbo.Categories", t => t.Category_idCat)
                .Index(t => t.Category_idCat);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        idCat = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.idCat);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Annonces", "Category_idCat", "dbo.Categories");
            DropIndex("dbo.Annonces", new[] { "Category_idCat" });
            DropTable("dbo.Categories");
            DropTable("dbo.Annonces");
        }
    }
}
