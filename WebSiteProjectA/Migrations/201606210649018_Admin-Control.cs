namespace WebSiteProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminControl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserProfile", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.UserProfile", "FirstName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.UserProfile", "LastName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.UserProfile", "MiddleName", c => c.String(maxLength: 150));
            AlterColumn("dbo.UserProfile", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "PhoneNumber", c => c.String());
            AlterColumn("dbo.UserProfile", "MiddleName", c => c.String());
            AlterColumn("dbo.UserProfile", "LastName", c => c.String());
            AlterColumn("dbo.UserProfile", "FirstName", c => c.String());
            AlterColumn("dbo.UserProfile", "Email", c => c.String());
        }
    }
}
