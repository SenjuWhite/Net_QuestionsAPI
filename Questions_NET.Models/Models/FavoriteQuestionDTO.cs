using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.Models.Models
{
    public class FavoriteQuestionDTO
    {
        public int UserId { get; set; }
        
        public int QuestionId { get; set; }
    }
}
