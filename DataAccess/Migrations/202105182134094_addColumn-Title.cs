﻿namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Title");
        }
    }
}
