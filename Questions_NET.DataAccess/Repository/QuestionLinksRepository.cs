using Net_QuestionsAPI.Models;
using Questions_NET.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
    public class QuestionLinksRepository : Repository<QuestionLink>, IQuestionLinksRepository
    {
        private ApplicationDbContext _db;
        public QuestionLinksRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
            
        }
        public void Update(QuestionLink questionLink)
        {
            _db.QuestionLinks.Update(questionLink);
        }
    }
}
