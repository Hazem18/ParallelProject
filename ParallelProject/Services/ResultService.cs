using ParallelProject.Models;
using ParallelProject.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services
{
    public class ResultService : IResultService
    {
        public Task<int> CalculateScoreAsync(IEnumerable<Question> questions, IEnumerable<Answer> userAnswers)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<QuizResult>> GetUserQuizResultsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task SubmitQuizResultAsync(QuizResult result)
        {
            throw new NotImplementedException();
        }
    }
}
