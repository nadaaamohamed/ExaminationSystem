using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TFQuestion :QuestionBase
    {
        public TFQuestion(string header, string body, decimal mark, Answer Answer) : base(header, body, mark)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark}) [True/False]");
        }
    }
}
