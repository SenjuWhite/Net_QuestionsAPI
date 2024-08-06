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
        Task<IEnumerable<T>> GetAllASync();
        Task<IEnumerable<T>> GetValuesASync(Expression<Func<T, bool>> filter);
        Task AddASync(T entity);
        int test();
        void Remove(T entity);
    }
}
