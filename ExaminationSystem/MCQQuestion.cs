using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQQuestion : QuestionBase
    {
        private readonly List<Answer>? answers;

        public MCQQuestion(string? header, string? body, decimal mark, List<Answer> ?answers, string correctAnswer) : base(header, body, mark)
        {
            this.answers = answers;
        }

        

        public override void Display()
        {
            Console.WriteLine($"{Header} : {Body}");
            for (int i = 0; i < answers?.Count; i++)
            {
                Console.WriteLine($"{Header} , {Body}");
                Console.WriteLine($"{i + 1}. {answers[i].AnswerText}");
            }
        }
       
    }
}
