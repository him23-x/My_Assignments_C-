using CSharpMiniProject.Collections;
using CSharpMiniProject.Enums;
using CSharpMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Exams
{
    public abstract class Exam
    {
        #region Prop
        public TimeSpan Time { get; set; }

        public QuestionList Questions { get; set; }

        public int NumberOfQuestions => Questions.Count;

        public Subject Subject { get; set; }

        public ExamMode Mode { get; private set; } 
        #endregion

        public Dictionary<Question, List<int>> QuestionAnswerDictionary { get; }

        protected Exam(TimeSpan time, Subject subject, QuestionList questions)
            : this(time, subject, questions, ExamMode.Queued) { }

        protected Exam(TimeSpan time, Subject subject, QuestionList questions, ExamMode mode)
        {
            Time = time;
            Subject = subject;
            Questions = questions;
            Mode = mode;

            QuestionAnswerDictionary =new Dictionary<Question, List<int>>();

            foreach (Question question in Questions)
            {
                QuestionAnswerDictionary.Add(
                    question,
                    new List<int>(question.CorrectAnswersId)
                );
            }
        }

        public abstract void ShowExam();

        public void Start()
        {
            Mode = ExamMode.Starting;
            ShowExam();
        }

        public void Finish()
        {
            Mode = ExamMode.Finished;
        }
    }
}
