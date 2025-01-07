using Questions_NET.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository.IRepository
{
    public interface IFavoriteQuestionRepository : IRepository<FavoriteQuestion>
    {
        void Update(FavoriteQuestion question);
        
    }
}
