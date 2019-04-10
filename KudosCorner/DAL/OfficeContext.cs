
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
        public DbSet<PsiogUser> PsiogUsers { get; set; }
        public DbSet<Wish> Wishes{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Kudo>()
           .HasMany(c=>c.Achievers).WithMany(m=>m.My_Achievements)
           .Map(t => t.MapLeftKey("KudoID")
           .MapRightKey("PsiogUserID")
           .ToTable("KudoPsiogUser"));
        }
    }
}