using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Models
{
    public class Answer
    {
        public int Id { get; set; }               
        public int QuizResultId { get; set; }     
        public int QuestionId { get; set; }      
        public int SelectedChoiceIndex { get; set; } 
        
        public QuizResult QuizResult { get; set; } = null!; 
        public Question Question { get; set; } = null!;
    }
}
