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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        //public void Save()
        //{
        //   _db.SaveChanges();
        //}

        public void Update(User user)
        {
            _db.Users.Update(user);
        }
    }
}
