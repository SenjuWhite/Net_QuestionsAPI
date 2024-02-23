using Microsoft.EntityFrameworkCore;
using Net_QuestionsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewQuestion> InterviewsQuestions { get; set; }
        public DbSet<QuestionLink> QuestionLinks { get; set; }

    }
}
