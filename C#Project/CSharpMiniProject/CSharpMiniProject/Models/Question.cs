using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Models
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }
        public List<int> CorrectAnswersId { get; set; }

        public Question(string header, string body, int marks, AnswerList answers, List<int> CorrectAnswersId)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = answers;
            this.CorrectAnswersId = CorrectAnswersId;
        }

        public Question(string header, string body, int marks)
            : this(header, body, marks, new AnswerList(), new List<int>()) { }

        public abstract void Display();
    }
}
