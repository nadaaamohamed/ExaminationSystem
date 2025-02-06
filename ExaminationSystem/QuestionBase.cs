using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class QuestionBase 
    {
        
        public string ?Header { get; set; } 
        public string ?Body { get; set; }
        public decimal Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer? RightAnswer    { get; set; }

        public QuestionBase(string? header, string? body, decimal mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }
        public abstract void Display();
        
    }
}
