namespace EntityModel.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityModel.DAL.RestorerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityModel.DAL.RestorerContext context)
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
            Job job = new Entities.Job();
            job.CreationTime = DateTime.Now;
            job.JobName = "Bicycle";
            job.PathImageBefore = "~/Content/Imagenes/img1.jpg ";
            job.StartTime = DateTime.Now;
            job.Description= "Bicycle of the year 1935 recovered from an old deposit near Chihuahua city. To restore it were used new techniques of recovery of metals and was necessary the importation of pieces from the United Kingdom";
            context.Jobs.AddOrUpdate(job);

            Job job1 = new Entities.Job();
            job1.CreationTime = DateTime.Now;
            job1.JobName = "Bicycle";
            job1.PathImageBefore = "~/Content/Imagenes/img2.jpg ";
            job1.StartTime = DateTime.Now;
            job1.Description = "Bicycle of the year 1935 recovered from an old deposit near Chihuahua city. To restore it were used new techniques of recovery of metals and was necessary the importation of pieces from the United Kingdom";
            context.Jobs.AddOrUpdate(job1);

        }
    }
}
