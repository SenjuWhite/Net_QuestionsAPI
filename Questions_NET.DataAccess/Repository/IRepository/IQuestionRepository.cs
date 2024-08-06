using Net_QuestionsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository.IRepository
{
    public interface IQuestionRepository :IRepository<Question>
    {
        void Update(Question question);
        //void Save();
    }
}
