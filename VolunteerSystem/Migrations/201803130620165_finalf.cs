namespace VolunteerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollment", "EnrollmentDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Event", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Volunteer", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunteer", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Event", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Enrollment", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
    }
}
