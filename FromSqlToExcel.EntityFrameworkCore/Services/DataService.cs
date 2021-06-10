using FromSqlToExcel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromSqlToExcel.EntityFrameworkCore.Services
{
    public class DataService<T> where T : class
    {
        private readonly FromSqlToExcelDbContextFactory _contexFactory;

        public DataService(FromSqlToExcelDbContextFactory contextFactory)
        {
            _contexFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using FromSqlToExcelDbContext context = _contexFactory.CreateDbContext();
            EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
            return createdResult.Entity;
        }
        
        public async Task<IEnumerable<T>> GetAll()
        {
            using FromSqlToExcelDbContext context = _contexFactory.CreateDbContext();
            IEnumerable<T> entities = await context.Set<T>().ToListAsync();
            return entities;
        }
        public async Task<Izdel> GetIzdel(int id)
        {
            using FromSqlToExcelDbContext context = _contexFactory.CreateDbContext();
            Izdel entity = await context.Set<Izdel>().FirstOrDefaultAsync(i => i.Id == id);
            return entity;
        }
        public async Task<Links> GetLink(string name)
        {
            using FromSqlToExcelDbContext context = _contexFactory.CreateDbContext();
            Links entity = await context.Set<Links>().FirstOrDefaultAsync(l => l.Izdel.Name == name);
            return entity;
        }
    }
}
