using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProject.Services
{
    public class ResultService : IResultService
    {
        private readonly ApplicationDbContext _context;

        public ResultService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Submit the quiz result (store the result in the database)
        public async Task SubmitQuizResultAsync(QuizResult result)
        {
            // Add the quiz result to the database
            _context.QuizResults.Add(result);
            await _context.SaveChangesAsync();
        }

        // Get all quiz results for a specific user
        public async Task<IEnumerable<QuizResult>> GetUserQuizResultsAsync(int userId)
        {
            // Fetch the results for a user including answers and the associated questions
            return await _context.QuizResults
                                 .Where(r => r.UserId == userId)
                                 .Include(r => r.Answers)
                                 .ThenInclude(a => a.Question)  // Include related question details
                                 .ToListAsync();
        }

        // Calculate the score based on the user's answers and the correct answers
        public async Task<int> CalculateScoreAsync(IEnumerable<Question> questions, IEnumerable<Answer> userAnswers)
        {
            int score = 0;

            // Iterate through the user's answers and compare with correct options
            foreach (var answer in userAnswers)
            {
                // Find the corresponding question for the answer
                var question = questions.FirstOrDefault(q => q.Id == answer.QuestionId);
                if (question != null)
                {
                    // Check if the selected answer matches the correct option
                    string correctOption = question.CorrectOption;
                    string selectedOption = GetOptionFromIndex(answer.SelectedChoiceIndex);
                    if (correctOption == selectedOption)
                    {
                        score++;
                    }
                }
            }

            return score;
        }

        // Helper method to map the selected choice index to the correct option letter
        private string GetOptionFromIndex(int index)
        {
            return index switch
            {
                0 => "A",
                1 => "B",
                2 => "C",
                3 => "D",
                _ => throw new ArgumentOutOfRangeException(nameof(index), "Invalid option index.")
            };
        }

        // Update the quiz result (update score and associated answers)
        public async Task UpdateQuizResultAsync(QuizResult quizResult)
        {
            var existingResult = await _context.QuizResults
                .Include(qr => qr.Answers)  // Ensure answers are included
                .FirstOrDefaultAsync(qr => qr.Id == quizResult.Id);

            if (existingResult != null)
            {
                // Update properties of existing result
                existingResult.Score = quizResult.Score;

                // Add or update the answers for the quiz result
                foreach (var answer in quizResult.Answers)
                {
                    var existingAnswer = existingResult.Answers
                        .FirstOrDefault(a => a.QuestionId == answer.QuestionId);
                    if (existingAnswer != null)
                    {
                        existingAnswer.SelectedChoiceIndex = answer.SelectedChoiceIndex;  // Update answer
                    }
                    else
                    {
                        existingResult.Answers.Add(answer);  // Add new answer if it doesn't exist
                    }
                }

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            else
            {
                // If no result exists, create a new result and add answers
                await _context.QuizResults.AddAsync(quizResult);
                await _context.SaveChangesAsync();
            }
        }
    }
}
