using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Models
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(
        string header,
        string body,
        int marks,
        AnswerList answers,
        List<int> correctAnswerIds)
        : base(header, body, marks, answers, correctAnswerIds)
        {
            if (answers.Count < 2)
                throw new ArgumentException(
                    "Choose One must have at least two answers.");

            if (correctAnswerIds.Count != 1)
                throw new ArgumentException(
                    "Choose One must have exactly one correct answer.");
        }

        public override void Display()
        {
            Console.WriteLine($"[Choose One] {Header}");
            Console.WriteLine(Body);
            Console.WriteLine($"Marks: {Marks}");

            foreach (Answer answer in Answers)
                Console.WriteLine(answer);
        }
    }
}
