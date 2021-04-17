namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "WriterId", c => c.Int(nullable: false));
            AddColumn("dbo.Contents", "WriterId", c => c.Int());
            CreateIndex("dbo.Headings", "WriterId");
            CreateIndex("dbo.Contents", "WriterId");
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "Id");
            AddForeignKey("dbo.Headings", "WriterId", "dbo.Writers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropIndex("dbo.Headings", new[] { "WriterId" });
            DropColumn("dbo.Contents", "WriterId");
            DropColumn("dbo.Headings", "WriterId");
        }
    }
}
