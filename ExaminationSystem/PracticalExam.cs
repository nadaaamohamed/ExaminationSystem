using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticalExam :Exam
    {

        public PracticalExam(int time , int numberquestion) : base(time , numberquestion) { }


        public override void ShwoExam()
        {
            Console.WriteLine("Practical Exam:");

            foreach (QuestionBase question in QuestionList?.GetQuestions() ?? new List<QuestionBase>())
            {
                decimal marks = 0;
                question.Display();
                Console.Write("Your Answer: ");
                string userAnswer = Console.ReadLine() ?? "0";
                if (userAnswer.Equals(question?.RightAnswer?.AnswerText ?? ""))
                {
                    marks += question?.Mark ?? 0;
                    Console.WriteLine($"Correct Answer {question?.RightAnswer?.AnswerText} your Mark : {question?.Mark}");
                }

                else
                
                    Console.WriteLine($"Wrong Answer your Mark : {marks} ");
                
            } 
            


        }
    }
}
