using Questions_NET.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
       
        private ApplicationDbContext _db;
        public IQuestionRepository Question { get; private set; }
        public IQuestionLinksRepository QuestionLink { get; private set; }
        public IInterviewQuestionRepository InterviewQuestion { get; private set; }
        public IInterviewRepository Interview { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Question = new QuestionRepository(_db);
            QuestionLink = new QuestionLinksRepository(_db);
            InterviewQuestion = new InterviewQuestionRepository(_db);
            Interview = new InterviewRepository(_db);
        }
        public async Task SaveASync()
        {
           await _db.SaveChangesAsync();
        }
    }

}
