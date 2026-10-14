using CSharpMiniProject.Collections;
using CSharpMiniProject.Exams;
using CSharpMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C# Programming");

            QuestionList questions = new QuestionList("ProgrammingQuestions.txt");

            AnswerList answers1 = new AnswerList
{
    new Answer(1, "True"),
    new Answer(2, "False")
};

            Question question1 = new TrueFalseQuestion(
                "Question 1",
                "C# supports OOP.",
                5,
                answers1,
                new List<int> { 1 }
            );

            AnswerList answers2 = new AnswerList
{
    new Answer(1, "HTML"),
    new Answer(2, "C#"),
    new Answer(3, "CSS")
};

            Question question2 = new ChooseOneQuestion(
                "Question 2",
                "Which is a programming language?",
                5,
                answers2,
                new List<int> { 2 }
            );

            questions.Add(question1);
            questions.Add(question2);

            Console.WriteLine("Choose exam type:");
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam");

            string choice = Console.ReadLine() ?? "";

            Exam exam;

            if (choice == "1")
            {
                exam = new PracticeExam(
                    TimeSpan.FromMinutes(30),
                    subject,
                    questions
                );
            }
            else if (choice == "2")
            {
                exam = new FinalExam(
                    TimeSpan.FromMinutes(30),
                    subject,
                    questions
                );
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            exam.Start();

            Console.WriteLine($"Exam mode: {exam.Mode}");


        }
    }
}
