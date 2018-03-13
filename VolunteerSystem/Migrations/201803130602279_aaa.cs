namespace VolunteerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Event", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Event", "Date", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
