using Net_QuestionsAPI.Models;
using Questions_NET.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
    public class InterviewQuestionRepository : Repository<InterviewQuestion>, IInterviewQuestionRepository
    {
        private ApplicationDbContext _db;
        public InterviewQuestionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
        public void Update(InterviewQuestion interview)
        {
            _db.InterviewsQuestions.Update(interview);
        }
    }
}
