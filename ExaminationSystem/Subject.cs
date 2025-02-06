using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {
        public int SubjectId { get; set; }  
        public string ?SubjectName { get; set; }

        public Exam ?Exam { get; set; }
        public Subject(int subjectId, string? subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Exam = exam;
              
        }

        public void CreateExam()
        {
            Console.Write("Enter number of questions: ");
            int numQuestions = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write("Enter question type (1: True or False, 2: MCQ): ");
                int qType = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter question Header: ");
                string header = Console.ReadLine() ?? "0";
                Console.Write("Enter question Body: ");
                string body = Console.ReadLine() ?? "0";
                Console.Write("Enter question Mark: ");
                int mark = int.Parse(Console.ReadLine() ?? "0");

                if (qType == 1)
                {
                    Console.Write("Enter correct answer (True/False): ");
                    string correctAnswer = Console.ReadLine() ?? "0";
                    Exam?.QuestionList?.AddQuestion(new TFQuestion(header, body, mark, new Answer(1, correctAnswer)));
                }
                else
                {
                    List<Answer> answers = new List<Answer>();
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write($"Enter Answer Choic {j}: ");
                        answers.Add(new Answer(j, Console.ReadLine()));
                    }
                    Console.Write("Enter correct answer: ");
                    string correctAnswer = Console.ReadLine() ?? "0";
                    Exam?.QuestionList?.AddQuestion(new MCQQuestion(header, body, mark, answers, correctAnswer));
                }

            }
        }


    }
}
