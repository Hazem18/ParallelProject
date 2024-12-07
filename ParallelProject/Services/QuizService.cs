using ParallelProject.Models;
using ParallelProject.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services
{
    public class QuizService : IQuizService
    {
        public Task AddQuestionToQuizAsync(int quizId, Question question)
        {
            throw new NotImplementedException();
        }

        public Task CreateQuizAsync(Quiz quiz)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Quiz>> GetAllQuizzesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetQuestionsForQuizAsync(int quizId)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz> GetQuizByIdAsync(int quizId)
        {
            throw new NotImplementedException();
        }
    }
}
