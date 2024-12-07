using ParallelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services.IServices
{
    public interface IQuizService
    {
        Task CreateQuizAsync(Quiz quiz); 
        Task<Quiz> GetQuizByIdAsync(int quizId); 
        Task<IEnumerable<Quiz>> GetAllQuizzesAsync(); 
        Task AddQuestionToQuizAsync(int quizId, Question question); 
        Task<IEnumerable<Question>> GetQuestionsForQuizAsync(int quizId);
    }
}
