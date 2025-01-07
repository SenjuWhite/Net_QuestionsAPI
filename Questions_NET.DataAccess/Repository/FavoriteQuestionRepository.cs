using Microsoft.EntityFrameworkCore;
using Net_QuestionsAPI.Models;
using Questions_NET.DataAccess.Repository.IRepository;
using Questions_NET.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
    public class FavoriteQuestionRepository : Repository<FavoriteQuestion>, IFavoriteQuestionRepository
    {
        private ApplicationDbContext _db;
        public FavoriteQuestionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
        public void Update(FavoriteQuestion favoriteQuestion)
        {
            _db.FavoriteQuestions.Update(favoriteQuestion);
        }
    }
}
