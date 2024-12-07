using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Models
{
    public class QuizResult
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int Quiz_Id { get; set; }
        public Quiz Quiz { get; set; } = null!;

        public int Score { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
