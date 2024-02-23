using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_QuestionsAPI.Models
{
    public class InterviewQuestion
    {
        [Key]
        public int IntQuestId { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public int InterviewId { get; set; }
        [Required]
        public int Timecode { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        [ForeignKey("InterviewId")]
        public Interview Interview { get; set; }
    }
}
