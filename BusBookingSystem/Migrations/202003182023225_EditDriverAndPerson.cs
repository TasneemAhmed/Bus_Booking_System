namespace BusBookingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDriverAndPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "Address", c => c.String());
            AddColumn("dbo.Drivers", "Salary", c => c.Single(nullable: false));
            AddColumn("dbo.Drivers", "EMail", c => c.String());
            AddColumn("dbo.Drivers", "UserName", c => c.String());
            AddColumn("dbo.Drivers", "Age", c => c.Byte(nullable: false));
            AddColumn("dbo.Drivers", "Gender", c => c.String());
            AddColumn("dbo.Users", "EMail", c => c.String());
            AddColumn("dbo.Users", "UserName", c => c.String());
            AddColumn("dbo.Users", "Age", c => c.Byte(nullable: false));
            AddColumn("dbo.Users", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Age");
            DropColumn("dbo.Users", "UserName");
            DropColumn("dbo.Users", "EMail");
            DropColumn("dbo.Drivers", "Gender");
            DropColumn("dbo.Drivers", "Age");
            DropColumn("dbo.Drivers", "UserName");
            DropColumn("dbo.Drivers", "EMail");
            DropColumn("dbo.Drivers", "Salary");
            DropColumn("dbo.Drivers", "Address");
        }
    }
}
