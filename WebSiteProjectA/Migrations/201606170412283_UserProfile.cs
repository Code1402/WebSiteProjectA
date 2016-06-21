namespace WebSiteProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Email", c => c.String());
            AddColumn("dbo.UserProfile", "FirstName", c => c.String());
            AddColumn("dbo.UserProfile", "LastName", c => c.String());
            AddColumn("dbo.UserProfile", "MiddleName", c => c.String());
            AddColumn("dbo.UserProfile", "PhoneNumber", c => c.String());
            AddColumn("dbo.UserProfile", "BirthMonth", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "BirthDay", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "BirthYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "BirthYear");
            DropColumn("dbo.UserProfile", "BirthDay");
            DropColumn("dbo.UserProfile", "BirthMonth");
            DropColumn("dbo.UserProfile", "PhoneNumber");
            DropColumn("dbo.UserProfile", "MiddleName");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "FirstName");
            DropColumn("dbo.UserProfile", "Email");
        }
    }
}
