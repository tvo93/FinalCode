namespace VolunteerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _fixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "Date", c => c.DateTime(nullable: false));
        }
    }
}
