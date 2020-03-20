namespace BusBookingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserPassword");
        }
    }
}
