using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SWABRA;database=Db_Space;integrated security=true;");
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<AboutTwo>? AboutTwos { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Experience>? Experiences { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<FeatureTwo>? FeatureTwos { get; set; }
        public DbSet<Mission>? Missions { get; set; }
        public DbSet<Skills>? Skills { get; set; }
        public DbSet<SubAbout>? SubAbouts { get; set; }
        public DbSet<Team>? Teams { get; set; }
    }
}
