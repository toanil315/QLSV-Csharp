using Microsoft.EntityFrameworkCore;

namespace PracticeMidTerm.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }

        public DbSet<Class> Class { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasOne(p => p.Class)
            .WithMany(c => c.Students)
            .HasForeignKey(p => p.ClassId);

            base.OnModelCreating(modelBuilder);
        }
    }
}