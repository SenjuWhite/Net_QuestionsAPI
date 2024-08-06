using Net_QuestionsAPI.Models;
using Questions_NET.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
    public class QuestionRepository : Repository<Question>,IQuestionRepository 
    {
       private ApplicationDbContext _db;
        public QuestionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;   
        }
        //public void Save()
        //{
        //   _db.SaveChanges();
        //}

        public void Update(Question question)
        {
            _db.Questions.Update(question);
        }
    }
}
