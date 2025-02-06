using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam(int time, int numberofquestion) : Exam(time, numberofquestion)
    {

        public override void ShwoExam()
        {
            {
                Console.WriteLine("Final Exam:");
                decimal marks = 0;
                foreach (QuestionBase question in QuestionList?.GetQuestions() ?? new List<QuestionBase>())
                {
                    question.Display();
                        Console.Write("Your Answer: ");
                        string userAnswer = Console.ReadLine() ?? "0";
                    if (userAnswer.Equals(question?.RightAnswer?.AnswerText ?? ""))

                    {
                        marks += question?.Mark ?? 0;
                        Console.WriteLine($"Correct Answer {question?.RightAnswer?.AnswerText} your Mark : {question?.Mark}");
                    }

                    else
                        
                    Console.WriteLine($"Wrong Answer your Mark : {marks}");
                    



                }



                

            }
        }
    }
}
