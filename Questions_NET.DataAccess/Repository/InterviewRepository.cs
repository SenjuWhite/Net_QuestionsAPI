using Net_QuestionsAPI.Models;
using Questions_NET.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository
{
   
        public class InterviewRepository : Repository<Interview>, IInterviewRepository
        {
            private ApplicationDbContext _db;
            public InterviewRepository(ApplicationDbContext db) : base(db)
            {
                _db = db;

            }
            public void Update(Interview interview)
            {
                _db.Interviews.Update(interview);
            }
        }
    }

