using Microsoft.EntityFrameworkCore;

namespace ITI_EF_WorkShop.Models
{
    internal class Trackercontext : DbContext
    {
        public DbSet<User> Users { get; set; }  
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Transaction> transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G6U036E\\SQLEXPRESS;Database=ExpensesTracker;Trusted_Connection=True;encrypt = false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
                { modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Category).WithMany(c => c.Transactions).
                HasForeignKey(t => t.CategoryID).OnDelete(DeleteBehavior.Cascade);
        }

    }
}
