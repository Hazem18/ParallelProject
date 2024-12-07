using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services;

namespace ParallelProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Ask the user how many operations they want to perform concurrently
            Console.Write("Enter the number of users to simulate: ");
            int userCount = int.Parse(Console.ReadLine());

            // Create tasks for registration and authentication
            var tasks = new List<Task>();

            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine($"\nUser {i + 1}:");

                // Input username and password for registration
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                // Start a task for registering and authenticating the user
                tasks.Add(Task.Run(async () =>
                {
                    // Ensure a unique DbContext instance for each task
                    using var context = new ApplicationDbContext();
                    var userService = new UserService(context);

                    try
                    {
                        // Register the user
                        var newUser = new User { Name = username, Password = password };
                        await userService.RegisterAsync(newUser);
                        Console.WriteLine($"User {username} registered successfully.");

                        // Authenticate the user
                        bool isAuthenticated = await userService.AuthenticateAsync(username, password);
                        Console.WriteLine(isAuthenticated
                            ? $"User {username} authenticated successfully."
                            : $"Authentication failed for {username}.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error for user {username}: {ex.Message}");
                    }
                }));
            }

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);

            Console.WriteLine("All operations completed.");
        }
    }
}
