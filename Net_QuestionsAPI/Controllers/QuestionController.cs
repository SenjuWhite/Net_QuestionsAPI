using Microsoft.AspNetCore.Mvc;
using Questions_NET.DataAccess.Repository;
using Questions_NET.DataAccess.Repository.IRepository;

namespace Net_QuestionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet("get_all")]
        //public async Task<IActionResult> GetQuestionsAsync()
        //{
        //    var query = await _unitOfWork.Question.GetAllASync();
        //    return Ok(query);
        //}
        [HttpGet("get_all")]
        public async Task<IActionResult> GetQuestionsAsync()
        {

            var questions = await _unitOfWork.Question.GetAllASync();
            var interviews = await _unitOfWork.Interview.GetAllASync();
            var interviewQuestions = await _unitOfWork.InterviewQuestion.GetAllASync();
            var query = from q in questions
                        join iq in interviewQuestions on q.QuestionId equals iq.QuestionId
                        join i in interviews on iq.InterviewId equals i.InterviewId
                        group new { q, i } by new { q.QuestionInfo, q.QuestionId } into g
                        select new
                        {
                            QuestionInfo = g.Key.QuestionInfo,
                            QuestionId = g.Key.QuestionId,
                            ciq = g.Count(),
                            Frequency = (g.Count() * 100) / interviews.Count(),
                            InterviewLevel = string.Join(",", g.Select(x => x.i.InterviewLevel).Distinct().OrderBy(level => level))
                        };


            var result = query.OrderByDescending(x => x.ciq).ToList();
            return Ok(result);
        }
        [HttpGet("get_by_Id")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var query = await _unitOfWork.Question.GetValuesASync(q => q.QuestionId == id);
            return Ok(query);
        }
        [HttpGet("get_question")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var questions = await _unitOfWork.Question.GetAllASync();
            var result = questions.Where(q => q.QuestionId == id).Select(x => x).FirstOrDefault();
            return Ok(result);

        }
        [HttpGet("get_questionlinks")]
        public async Task<IActionResult> GetQuestionLinks(int id)
        {
            var questionLinks = await _unitOfWork.QuestionLink.GetAllASync();
            var result = questionLinks.Where(ql => ql.QuestionId == id).Select(ql => ql.Link).ToList();
            return Ok(result);

        }
        [HttpGet("get_timecodes")]

        public async Task<IActionResult> GetTimecodes(int id)
        {
            var interviews = await _unitOfWork.Interview.GetAllASync();
            var interviewQuestions = await _unitOfWork.InterviewQuestion.GetAllASync();
            var query = interviewQuestions.Where(iq => iq.QuestionId == id).Select(iq => iq).ToList();
            var result = from q in query
                         join i in interviews on q.InterviewId equals i.InterviewId
                         select new
                         {   InterviewName = i.InterviewName,
                             Timecode = q.Timecode,
                             Link = i.InterviewLink,

                         };
            return Ok(result);
        }
        [HttpGet("get_interviews")]
        public async Task<IActionResult> GetInterviews()
        {
            var interviews = await _unitOfWork.Interview.GetAllASync();
            return Ok(interviews);
        }
    }
}
