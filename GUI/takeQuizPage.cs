using ParallelProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class takeQuizPage : Form
    {
        private readonly QuizService _quizService;
        private readonly ResultService _resultService; // Add ResultService
        private readonly int _userId;

        public takeQuizPage(QuizService quizService, ResultService resultService, int userId) // Update constructor
        {
            InitializeComponent();
            _quizService = quizService;
            _resultService = resultService; // Initialize ResultService
            _userId=userId;
        }

        // Load the quizzes into the DataGridView
        private async void takeQuizPage_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch all quizzes asynchronously
                var quizzes = await _quizService.GetAllQuizzesAsync();

                // Clear any existing items
                QuizDataGridView.Rows.Clear();

                // Add each quiz to the DataGridView
                foreach (var quiz in quizzes)
                {
                    QuizDataGridView.Rows.Add(quiz.Id, quiz.Title);
                }
            }
            catch (Exception ex)
            {
                // Handle errors, like network or DB issues
                MessageBox.Show($"Error loading quizzes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle quiz selection from the DataGridView
        private async void QuizDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedQuizId = (int)QuizDataGridView.Rows[e.RowIndex].Cells["QuizId"].Value;

                // Fetch questions for the selected quiz using QuizService
                try
                {
                    var quizQuestionsPage = new quizPage(_quizService, _resultService, selectedQuizId,_userId); // Pass all required arguments
                    quizQuestionsPage.Show(); // Show the quiz questions page
                    this.Hide(); // Hide the current page (takeQuizPage)
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching quiz questions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Start button event handler (if needed)
        private void StartBtn_Click(object sender, EventArgs e)
        {
            // This button currently doesn't do anything specific
            // If you want to add any logic here, you can do so
        }
    }
}