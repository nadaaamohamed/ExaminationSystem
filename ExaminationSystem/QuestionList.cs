using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class QuestionList
    {
        private List<QuestionBase> questions;
        public QuestionList()
        {
            questions = new List<QuestionBase>();
        }

        public void AddQuestion(QuestionBase question)
        {
            if(questions is not null ) 
            questions.Add(question);
        }

        public void DisplayAll()
        {
            if (questions is not null)
             foreach (var question in questions)
               Console.WriteLine(question);
            Console.WriteLine("===================");
        }
        public List<QuestionBase>? GetQuestions()
        {
           return questions;
            
        }
    }
}
