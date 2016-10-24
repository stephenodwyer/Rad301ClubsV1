namespace Rad301ClubsV1.Migrations.ClubModelMigrations
{
    using Models.ClubModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rad301ClubsV1.Models.ClubModel.ClubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClubModelMigrations";
        }

        protected override void Seed(Rad301ClubsV1.Models.ClubModel.ClubContext context)
        {
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club { ClubName = "The Tiddly Winks Club", CreationDate = DateTime.Now });
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club { ClubName = "The Chess Club", CreationDate = DateTime.Now });
        }
    }
}
