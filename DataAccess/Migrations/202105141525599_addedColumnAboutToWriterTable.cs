namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedColumnAboutToWriterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "About", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "Image", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "Image", c => c.String());
            AlterColumn("dbo.Writers", "Email", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "About");
        }
    }
}
