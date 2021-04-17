namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitiaCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "WriterId" });
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropColumn("dbo.Headings", "WriterId");
            DropColumn("dbo.Contents", "WriterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "WriterId", c => c.Int());
            AddColumn("dbo.Headings", "WriterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contents", "WriterId");
            CreateIndex("dbo.Headings", "WriterId");
            AddForeignKey("dbo.Headings", "WriterId", "dbo.Writers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "Id");
        }
    }
}
