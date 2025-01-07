using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IQuestionRepository Question { get; }
        IQuestionLinksRepository QuestionLink { get; }
        IInterviewRepository Interview { get; }
        IInterviewQuestionRepository InterviewQuestion { get; }
        IUserRepository User { get; }
        IFavoriteQuestionRepository FavoriteQuestion { get; }
        Task SaveAsync();
    }
}
