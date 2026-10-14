using CSharpMiniProject.Collections;
using CSharpMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(
        TimeSpan time,
        Subject subject,
        QuestionList questions)
        : base(time, subject, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("=== Final Exam ===");
            Console.WriteLine($"Subject: {Subject.Name}");
            Console.WriteLine($"Duration: {Time}");
            Console.WriteLine();

            foreach (Question question in Questions)
            {
                question.Display();

                Console.Write("Enter answer ID(s): ");
                string input = Console.ReadLine() ?? "";

                List<int> selectedIds = new List<int>();

                foreach (string part in input.Split(','))
                {
                    if (int.TryParse(part.Trim(), out int id))
                    {
                        selectedIds.Add(id);
                    }
                }

                Console.WriteLine();
            }

            Finish();

            Console.WriteLine("Final exam finished.");
        }
    }
}
