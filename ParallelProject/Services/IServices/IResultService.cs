using ParallelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services.IServices
{
    public interface IResultService
    {
        Task SubmitQuizResultAsync(QuizResult result);
        Task<IEnumerable<QuizResult>> GetUserQuizResultsAsync(int userId);
        Task<int> CalculateScoreAsync(IEnumerable<Question> questions, IEnumerable<Answer> userAnswers);
    }
}
