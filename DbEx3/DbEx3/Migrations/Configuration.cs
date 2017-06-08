namespace DbEx3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbEx3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(DbEx3.Models.ApplicationDbContext context)
        {
            if (context.Roles.Any())
            {
                Initializer.SeedRoles(context);
            }
            
            if (context.Users.Any())
            {
                Initializer.SeedUser(context);
            }
            
        }
    }
}
