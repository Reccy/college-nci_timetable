namespace NCIOnlineTimetable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Slots", "Name", c => c.String());
            AddColumn("dbo.Timetables", "Semester_Id", c => c.Int());
            CreateIndex("dbo.Timetables", "Semester_Id");
            AddForeignKey("dbo.Timetables", "Semester_Id", "dbo.Semesters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Timetables", "Semester_Id", "dbo.Semesters");
            DropIndex("dbo.Timetables", new[] { "Semester_Id" });
            DropColumn("dbo.Timetables", "Semester_Id");
            DropColumn("dbo.Slots", "Name");
        }
    }
}
