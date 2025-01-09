using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int NumOfQuestion) : base(time, NumOfQuestion)
        {
        }

        public override void CreateListOfQuestion()
        {
            Questions = new Questions[NumOfQuestion];
            for (int i = 0; i < Questions?.Length; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Please Enter Your Choice 1 For MCQ , 2 For T/F");

                }
                while (!(int.TryParse(Console.ReadLine() , out choice) && (choice is 1 or 2)));
                if (choice == 1)
                {
                    Questions[i] = new McqQuestion();
                    Questions[i].AddQuestions();
                }
                else
                {
                    Questions[i] = new TrueOrFaulsQuestion();
                    Questions[i].AddQuestions();
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var questuion in Questions)
            {
                Console.WriteLine(questuion);
                for (int i = 0; i < questuion.Answers.Length; i++)
                    Console.WriteLine(questuion.Answers[i]);
                int userAnswerId;
                if (questuion.Answers.GetType() == typeof(McqQuestion))
                {
                    do
                    {
                        Console.WriteLine("Please Enter the right answer Id");
                    }
                    while (!(int.TryParse(Console.ReadLine() , out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please Enter the right answer Id 1 For True and 2 For False");
                    }
                    while (!(int.TryParse(Console.ReadLine() , out userAnswerId) && (userAnswerId is 1 or 2)));
                }
                questuion.UserAnswer.Id = userAnswerId;
                questuion.UserAnswer.Text = questuion.Answers[userAnswerId -1 ].Text;
            }
            Console.Clear();
            int grade = 0, totalMark = 0;
            for (int i = 0; i < Questions?.Length; i++)
            {
                totalMark += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id  == Questions[i].RightAnswer.Id)
                {
                    grade += Questions[i].Mark;
                }
                Console.WriteLine($"{i + 1}) : {Questions[i].Body}");
                Console.WriteLine($"Your Answer --> {Questions[i].UserAnswer.Text}");
                Console.WriteLine($"Right Answer --> {Questions[i].RightAnswer.Text}");
                Console.WriteLine("***************************");
            }
            Console.WriteLine($"Your Grade is {grade} out of {totalMark}");
        }
    }
}
