using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(1, "C#");
            sub1.CreateExam();
            Console.Clear();
            char userChoice;
            do
            {
                Console.WriteLine("Please enter Y to start Exam | N to exit");
            } while (!(char.TryParse(Console.ReadLine(), out userChoice) && (userChoice == 'Y' || userChoice == 'y' || userChoice == 'N' || userChoice == 'n')));
            if (userChoice == 'Y' || userChoice == 'y')
            {
                Console.Clear();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub1.SubjectExam.ShowExam();
                stopwatch.Stop();
                Console.WriteLine($"You Take {stopwatch.Elapsed} to solve the exam");
            }
        }
    }
}
