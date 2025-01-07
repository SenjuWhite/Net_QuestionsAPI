using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Questions_NET.DataAccess.Repository.IRepository;
namespace Questions_NET.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            
            await dbSet.AddAsync(entity);
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> query = dbSet;
            return await query.ToListAsync();
        }


        public async Task<T> GetValueAsync(Expression<Func<T, bool>> filter)
        {
            return await dbSet.FirstOrDefaultAsync(filter);
        }

        public async Task<IEnumerable<T>> GetValuesAsync(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
           query = query.Where(filter);
            return await query.ToListAsync();
        }
        

        public void Remove(T entity)
        {
           dbSet.Remove(entity);
        }
        public int test()
        {
            return 5;
        }
    }
}
