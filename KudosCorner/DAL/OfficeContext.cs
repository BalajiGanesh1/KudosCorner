
using KudosCorner.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace KudosCorner.DAL
{
    public class OfficeContext:DbContext
    {
        public OfficeContext() : base("OfficeContext")
        {

        }

        public DbSet<Kudo> Kudos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wish> Wishes{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}