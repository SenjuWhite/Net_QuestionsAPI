using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_QuestionsAPI.Models
{
    public class QuestionLink
    {
        [Key]
        public int QuestionLinkId { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
       

    }
}
