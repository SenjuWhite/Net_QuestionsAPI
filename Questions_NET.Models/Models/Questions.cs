using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_QuestionsAPI.Models
{

    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public string QuestionInfo { get; set; }
        [Required]
        public string QuestionAnswer { get; set; }
        
        

        

    }
}
