using KidsChurch.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KidsChurch.DAL
{
    public class KidsChurchContext : DbContext
    {
        public KidsChurchContext() : base("KidsChurchContext")
        {

        }

        public DbSet<Child> children { get; set; }
        public DbSet<CheckIn> checkIns { get; set; }
        public DbSet<Bible> numBibleBrought { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}