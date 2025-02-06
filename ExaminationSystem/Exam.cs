using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
        public int Time {  get; set; }
        public int NumberOfQuestion { get; set; }
        public QuestionList QuestionList { get; set; }

        public Exam (int time, int numberOfQuestion)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestion;
            QuestionList = new QuestionList();
        }

        public abstract void ShwoExam();
    }
}
