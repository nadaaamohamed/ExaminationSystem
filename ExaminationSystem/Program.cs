using ExaminationSystem;
using System.Diagnostics;

//List<Answer> ans = new List<Answer>
//{
//    new Answer(1,"True"),
//    new Answer(2, "false"),
//    new Answer(3, "True"),
//    new Answer(4, "false")
//};

//MCQQuestion c = new MCQQuestion("Q1", "C#", 5, ans, "nada");
//c.Display();

//Console.WriteLine("==========================");

Subject Sub1 = new Subject(10, "C#", new FinalExam(60, 2));
Subject Sub2 = new Subject(5, "Java", new PracticalExam(60, 2));
Sub2.CreateExam();
Console.Clear();
Console.Write("Do You Want To Start The Exam (y | n): ");
char input = char.Parse(Console.ReadLine() ?? "0");

if (input == 'y' || input == 'Y')
{
    Stopwatch SW = new Stopwatch();
    SW.Start();
    Sub2?.Exam?.ShwoExam();
    SW.Stop();
    Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
}


