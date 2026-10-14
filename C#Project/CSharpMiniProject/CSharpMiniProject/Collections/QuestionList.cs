using CSharpMiniProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Collections
{
    public class QuestionList : List<Question>
    {
        public string FilePath { get; }

        public QuestionList(string filePath)
        {
            FilePath = filePath;
        }

        public new void Add(Question question)
        {
            base.Add(question);


            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"Type: {question.GetType().Name}");
                writer.WriteLine($"Header: {question.Header}");
                writer.WriteLine($"Body: {question.Body}");
                writer.WriteLine($"Marks: {question.Marks}");
                writer.WriteLine("Answers:");

                foreach (Answer answer in question.Answers)
                {
                    writer.WriteLine(answer.ToString());
                }

                writer.WriteLine("-------------------------");
            }
        }
    }
}
