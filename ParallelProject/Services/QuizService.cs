using Microsoft.EntityFrameworkCore;
using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProject.Services
{
    public class QuizService : IQuizService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public QuizService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateQuizAsync(Quiz quiz)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                Console.WriteLine($"Creating quiz '{quiz.Title}' on thread {Thread.CurrentThread.ManagedThreadId}");
                context.Quizzes.Add(quiz);
                await context.SaveChangesAsync();
                Console.WriteLine($"Quiz '{quiz.Title}' created successfully on thread {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public async Task<Quiz> GetQuizByIdAsync(int quizId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                Console.WriteLine($"Fetching quiz ID {quizId} on thread {Thread.CurrentThread.ManagedThreadId}");
                return await context.Quizzes.FindAsync(quizId);
            }
        }

        public async Task<IEnumerable<Quiz>> GetAllQuizzesAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                Console.WriteLine($"Fetching all quizzes on thread {Thread.CurrentThread.ManagedThreadId}");
                return await context.Quizzes.ToListAsync();
            }
        }

        public async Task<IEnumerable<Answer>> GetUserAnswersForQuizAsync(int quizId, int userId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                // Fetch the answers for the given quiz and user
                return await context.Answers
                    .Where(a => a.QuizResult.Quiz_Id == quizId && a.QuizResult.UserId == userId)
                    .ToListAsync();
            }
        }
        public async Task AddQuestionToQuizAsync(int quizId, Question question)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                Console.WriteLine($"Adding question to quiz ID {quizId} on thread {Thread.CurrentThread.ManagedThreadId}");
                var quiz = await context.Quizzes.Include(q => q.Questions).FirstOrDefaultAsync(q => q.Id == quizId);
                if (quiz != null)
                {
                    quiz.Questions.Add(question);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<IEnumerable<Question>> GetQuestionsForQuizAsync(int quizId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                Console.WriteLine($"Fetching questions for quiz ID {quizId} on thread {Thread.CurrentThread.ManagedThreadId}");
                var quiz = await context.Quizzes.Include(q => q.Questions).FirstOrDefaultAsync(q => q.Id == quizId);
                return quiz?.Questions ?? Enumerable.Empty<Question>();
            }
        }
    }
}
