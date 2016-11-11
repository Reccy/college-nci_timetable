namespace NCIOnlineTimetable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Floor = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Term = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Slots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Int(nullable: false),
                        EndTime = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Room_Id = c.Int(),
                        Timetable_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .ForeignKey("dbo.Timetables", t => t.Timetable_Id)
                .Index(t => t.Room_Id)
                .Index(t => t.Timetable_Id);
            
            CreateTable(
                "dbo.Timetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsCourse = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Slots", "Timetable_Id", "dbo.Timetables");
            DropForeignKey("dbo.Slots", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Slots", new[] { "Timetable_Id" });
            DropIndex("dbo.Slots", new[] { "Room_Id" });
            DropTable("dbo.Timetables");
            DropTable("dbo.Slots");
            DropTable("dbo.Semesters");
            DropTable("dbo.Rooms");
        }
    }
}
