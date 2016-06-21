namespace WebSiteProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "DateTime", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfile", "BirthMonth");
            DropColumn("dbo.UserProfile", "BirthDay");
            DropColumn("dbo.UserProfile", "BirthYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "BirthYear", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "BirthDay", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "BirthMonth", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfile", "DateTime");
        }
    }
}
