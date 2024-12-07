using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? Title { get; set; }  
        public string? Description { get; set; }

        public ICollection<QuizResult> QuizResults { get; set; } = new List<QuizResult>();
        public ICollection<Question> Questions { get; set; }  = new List<Question>();
    }
}
