using System.ComponentModel.DataAnnotations;

namespace Net_QuestionsAPI.Models
{
    public class Interview
    {
        [Key]
        public int InterviewId { get; set; }
        [Required]
        public string InterviewLink { get; set; }
        [Required]
        public int InterviewLevel { get; set; }
        [Required]
        public string InterviewName { get; set;}

    }
}
