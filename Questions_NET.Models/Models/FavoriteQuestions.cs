using Net_QuestionsAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_NET.Models.Models
{
    public class FavoriteQuestion
    {
        [Key]
        public int FavoriteQuestionId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
