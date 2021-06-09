using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FromSqlToExcel.EntityFrameworkCore
{
    public class FromSqlToExcelDbContextFactory : IDesignTimeDbContextFactory<FromSqlToExcelDbContext>
    {
        

        public FromSqlToExcelDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<FromSqlToExcelDbContext>();
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SimpleTraderDB;Trusted_Connection=true");
            return new FromSqlToExcelDbContext(options.Options);
        }
    }
}
