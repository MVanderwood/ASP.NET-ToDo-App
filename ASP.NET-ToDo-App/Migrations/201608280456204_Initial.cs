namespace ASP.NET_ToDo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.TDTask",
                c => new
                    {
                        TDTaskID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Completed = c.Boolean(nullable: false),
                        Priority = c.Int(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TDTaskID)
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TDTask", "ProjectID", "dbo.Project");
            DropIndex("dbo.TDTask", new[] { "ProjectID" });
            DropTable("dbo.TDTask");
            DropTable("dbo.Project");
        }
    }
}
