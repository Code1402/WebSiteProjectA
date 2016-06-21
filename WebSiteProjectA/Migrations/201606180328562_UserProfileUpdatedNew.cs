namespace WebSiteProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileUpdatedNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserProfile", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "DateTime", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfile", "BirthDate");
        }
    }
}
