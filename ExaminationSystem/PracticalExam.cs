using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int NumOfQuestion) : base(time, NumOfQuestion)
        {
        }

        public override void CreateListOfQuestion()
        {
            Questions = new McqQuestion[NumOfQuestion];
            for (int i = 0; i < Questions?.Length; i++)
            {
                Questions[i] = new McqQuestion();
                Questions[i].AddQuestions();
            }
        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                for (int i = 0; i < question.Answers.Length; i++)
                {
                    Console.WriteLine(question.Answers[i]);
                }
                Console.WriteLine("---------------------------");
                int userAnswerId;
                do
                {
                    Console.WriteLine("Please Enter the right answer Id");
                }
                while (!(int.TryParse(Console.ReadLine() , out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;
            }
            Console.Clear();
            Console.WriteLine("Right Answers For Practical Exam");
            for (int i = 0; i < Questions?.Length; i++)
            {
                Console.WriteLine(Questions[i].Body);
                Console.WriteLine(Questions[i].RightAnswer.Text);
                Console.WriteLine("--------------------------");
            }

        }
    }
}
