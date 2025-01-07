using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetValuesAsync(Expression<Func<T, bool>> filter);
        Task<T> GetValueAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        int test();
        void Remove(T entity);
    }
}
