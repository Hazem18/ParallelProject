using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services;
using ParallelProject.Services.IServices;

namespace ParallelProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Set up dependency injection
            var services = new ServiceCollection();
            services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer("Data Source = YOUSSEFLAWENDY\\SQLEXPRESS; Initial Catalog = QuizSystem; Integrated Security = True; TrustServerCertificate = True"));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IQuizService, QuizService>();
            services.AddScoped<IResultService, ResultService>();

            var serviceProvider = services.BuildServiceProvider();

            // Fetch required services
            var userService = serviceProvider.GetRequiredService<IUserService>();
            var quizService = serviceProvider.GetRequiredService<IQuizService>();
            var resultService = serviceProvider.GetRequiredService<IResultService>();

            Console.WriteLine("Welcome to the Quiz System!");

            // Ask the user if they have an account
            Console.Write("Do you have an account? (yes/no): ");
            var answer = Console.ReadLine()?.ToLower();

            User currentUser = null;

            // If user has an account, attempt to log in
            if (answer == "yes")
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();

                // Authenticate the user
                bool isAuthenticated = await userService.AuthenticateAsync(name, password);
                if (isAuthenticated)
                {
                    currentUser = await userService.GetAllUsersAsync()
                        .ContinueWith(task => task.Result.FirstOrDefault(u => u.Name == name && u.Password == password));

                    Console.WriteLine($"Welcome back, {currentUser.Name}!");
                }
                else
                {
                    Console.WriteLine("Authentication failed. Please check your credentials.");
                    return;
                }
            }
            // If the user does not have an account, they need to register
            else if (answer == "no")
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();

                var newUser = new User { Name = name, Password = password, RoleId = 2 }; // Assuming default role is 2 (e.g., normal user)
                await userService.RegisterAsync(newUser);
                Console.WriteLine($"User {newUser.Name} registered successfully!");

                // Authenticate the newly registered user
                currentUser = newUser;
            }
            else
            {
                Console.WriteLine("Invalid option. Exiting program.");
                return;
            }

            // Show all quizzes
            var quizzes = await quizService.GetAllQuizzesAsync();
            Console.WriteLine("Available quizzes:");
            foreach (var quiz in quizzes)
            {
                Console.WriteLine($"ID: {quiz.Id}, Title: {quiz.Title}");
            }

            // Let the user pick a quiz
            Console.Write("Enter the quiz ID to take the quiz: ");
            int quizId = int.Parse(Console.ReadLine());

            // Fetch questions for the selected quiz
            var questions = await quizService.GetQuestionsForQuizAsync(quizId);
            if (questions == null || !questions.Any())
            {
                Console.WriteLine("No questions found for this quiz.");
                return;
            }

            // Start the quiz
            Console.WriteLine("\nStarting the quiz...");
            var quizResult = new QuizResult
            {
                UserId = currentUser.Id,
                Quiz_Id = quizId
            };
            await resultService.SubmitQuizResultAsync(quizResult); // Initialize the quiz result

            foreach (var question in questions)
            {
                Console.WriteLine($"\nQuestion: {question.Text}");
                Console.WriteLine($"A) {question.OptionA}");
                Console.WriteLine($"B) {question.OptionB}");
                Console.WriteLine($"C) {question.OptionC}");
                Console.WriteLine($"D) {question.OptionD}");

                Console.Write("Select your answer (A, B, C, D): ");
                string userAnswerInput = Console.ReadLine()?.ToUpper();

                // Add the user's answer to the quiz result
                var userAnswer = new Answer
                {
                    QuestionId = question.Id,
                    SelectedChoiceIndex = userAnswerInput == "A" ? 0 :
                                          userAnswerInput == "B" ? 1 :
                                          userAnswerInput == "C" ? 2 : 3, // Mapping A, B, C, D to indices 0, 1, 2, 3
                    QuizResultId = quizResult.Id
                };

                quizResult.Answers.Add(userAnswer); // Add the answer to the quiz result
            }

            // Calculate the score
            var score = 0;
            foreach (var userAnswer in quizResult.Answers)
            {
                var question = questions.FirstOrDefault(q => q.Id == userAnswer.QuestionId);
                if (question != null && userAnswer.SelectedChoiceIndex == GetOptionIndex(question.CorrectOption))
                {
                    score++;
                }
            }

            quizResult.Score = score; // Set the calculated score in the quiz result
            await resultService.UpdateQuizResultAsync(quizResult); // Save the updated result

            // Display the score
            Console.WriteLine($"\nQuiz completed. Here's your result:");
            Console.WriteLine($"Your score is: {score}/{questions.Count()}");

            Console.WriteLine("Your score has been saved under your account.");
        }

        // Helper method to map correct option (A, B, C, D) to index
        private static int GetOptionIndex(string correctOption)
        {
            return correctOption switch
            {
                "A" => 0,
                "B" => 1,
                "C" => 2,
                "D" => 3,
                _ => -1
            };
        }
    }
}