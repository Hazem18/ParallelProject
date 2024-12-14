using Microsoft.EntityFrameworkCore;
using ParallelProject.Data;

namespace GUI
{
    public partial class Quizzilles : Form
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        public Quizzilles(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage login = new(_dbContextFactory);
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupPage signUp = new(_dbContextFactory);
            signUp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
