using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueOrFaulsQuestion : Questions
    {
        public override string Header => "True Or Fales Question";

        public TrueOrFaulsQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "true");
            Answers[1] = new Answer(2, "Fales");
        }

        public override void AddQuestions()
        {
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Please Add the body of the Qusetion");
                Body = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(Body));
            int mark;
            do
            {
                Console.WriteLine("Please Add the mark of the Qusetion");
            }
            while (!(int.TryParse(Console.ReadLine() , out mark) && (mark > 0)));
            Mark = mark;
            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Enter 1 For True , 2 For False");
            }
            while (!(int.TryParse(Console.ReadLine() , out rightAnswerId) && (rightAnswerId is 1 or 2)));
            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId - 1 ].Text;
            Console.Clear();
        }
    }
}
