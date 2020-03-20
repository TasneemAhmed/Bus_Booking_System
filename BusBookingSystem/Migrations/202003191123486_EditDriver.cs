namespace BusBookingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDriver : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Age");
            DropColumn("dbo.Users", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Gender", c => c.String());
            AddColumn("dbo.Users", "Age", c => c.Byte(nullable: false));
        }
    }
}
