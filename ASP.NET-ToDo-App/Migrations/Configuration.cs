namespace ASP.NET_ToDo_App.Migrations
{
    using System;
    using System.Linq;

    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP.NET_ToDo_App.Contexts.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contexts.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            string[] descriptions = new string[3]
            {
                "Building a super fancy website",
                "Becoming President of The United States of America",
                "Aw shit...supertrip!"
            };
            context.Projects.AddOrUpdate(x => x.ProjectID,
                new Project() { ProjectID = 1, Description = descriptions[0] },
                new Project() { ProjectID = 2, Description = descriptions[1] },
                new Project() { ProjectID = 3, Description = descriptions[2] }
            );

            context.Tasks.AddOrUpdate(x => x.TDTaskID,
                new TDTask()
                {
                    TDTaskID = 1,
                    Description = "Setup DevOps.",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 1
                },
                new TDTask()
                {
                    TDTaskID = 2,
                    Description = "Deploy.",
                    Completed = false,
                    Priority = 3,
                    ProjectID = 1
                },
                new TDTask()
                {
                    TDTaskID = 3,
                    Description = "Debug.",
                    Completed = false,
                    Priority = 6,
                    ProjectID = 1
                },
                new TDTask()
                {
                    TDTaskID = 4,
                    Description = "Get super rich bro.",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 2
                },
                new TDTask()
                {
                    TDTaskID = 5,
                    Description = "Get super corrupt bro.",
                    Completed = false,
                    Priority = 3,
                    ProjectID = 2
                },
                new TDTask()
                {
                    TDTaskID = 6,
                    Description = "Buy Friends.",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 2
                },
                new TDTask()
                {
                    TDTaskID = 7,
                    Description = "BUY THE BANANANA!!!",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 3
                },
                new TDTask()
                {
                    TDTaskID = 8,
                    Description = "GET SOME CHIIPS!!",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 3
                },
                new TDTask()
                {
                    TDTaskID = 9,
                    Description = "THE FEEEELS!!",
                    Completed = false,
                    Priority = 1,
                    ProjectID = 3
                }
            );
        }
    }
}
