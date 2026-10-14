using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Models
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(
        string header,
        string body,
        int marks,
        AnswerList answers,
        List<int> correctAnswerIds)
        : base(header, body, marks, answers, correctAnswerIds)
        {
            if (answers.Count < 2)
                throw new ArgumentException(
                    "Choose All must have at least two answers.");

            if (correctAnswerIds.Count == 0)
                throw new ArgumentException(
                    "Choose All must have at least one correct answer.");
        }

        public override void Display()
        {
            Console.WriteLine($"[Choose All] {Header}");
            Console.WriteLine(Body);
            Console.WriteLine($"Marks: {Marks}");

            foreach (Answer answer in Answers)
                Console.WriteLine(answer);
        }
    }
}
