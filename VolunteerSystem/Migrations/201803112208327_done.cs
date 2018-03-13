namespace VolunteerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class done : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "Date", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
