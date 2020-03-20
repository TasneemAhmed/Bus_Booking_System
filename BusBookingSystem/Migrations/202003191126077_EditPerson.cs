namespace BusBookingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "PhoneNumber", c => c.Long(nullable: false));
            AddColumn("dbo.Users", "PhoneNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PhoneNumber");
            DropColumn("dbo.Drivers", "PhoneNumber");
        }
    }
}
