using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ParallelProject.Data;
using ParallelProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginPage : Form
    {

        private readonly UserService _userService;
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public LoginPage(IDbContextFactory<ApplicationDbContext> _dbContextFactory)
        {
            InitializeComponent();
            _userService = new UserService(_dbContextFactory);
            this._dbContextFactory=_dbContextFactory;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Retrieve input from text fields
            string username = UserFiled.Text;
            string password = PasswordFiled.Text;

            // Authenticate the user using UserService
            try
            {
                bool isAuthenticated = await _userService.AuthenticateAsync(username, password);

                if (isAuthenticated)
                {
                    var quizService = new QuizService(_dbContextFactory);

                    // Use the factory to create a context instance
                    var dbContext = _dbContextFactory.CreateDbContext();
                    var resultService = new ResultService(dbContext); // Pass the created context
                                                                      // Get the authenticated user ID from the UserService
                    int userId = (int)await _userService.GetUserIdAsync(username);
                    int roleId = (int)await _userService.GetRoleIdAsync(username);
                    // If authentication succeeds, show the quiz page
                    takeQuizPage quizPage = new(quizService, resultService,userId); // Pass both QuizService and ResultService
                    AddQuiz addquiz = new AddQuiz(quizService);
                    
                    if (roleId == 1)
                        addquiz.Show();
                    else
                    quizPage.Show();

                    this.Hide();
                }
                else
                {
                    // If authentication fails, show an error message
                    MessageBox.Show("Invalid username or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserFiled_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
