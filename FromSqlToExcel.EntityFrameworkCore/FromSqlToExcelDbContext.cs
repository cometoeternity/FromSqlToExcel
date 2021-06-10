using FromSqlToExcel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FromSqlToExcel.EntityFrameworkCore
{
    public class FromSqlToExcelDbContext : DbContext
    {
        public DbSet<Izdel> Izdels { get; set; }
        public DbSet<Links> Accounts { get; set; }
        

        public FromSqlToExcelDbContext([NotNull] DbContextOptions options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=IzdeliyaDB;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Links>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}

