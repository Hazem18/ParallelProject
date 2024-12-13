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
    public partial class takeQuizPage : Form
    {
        public takeQuizPage()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            quizPage QuizPage = new();
            QuizPage.Show();
            this.Hide();
        }
    }
}
