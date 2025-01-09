using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }
        public Subject() { }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            int examType, time, numberOfQuestion;
            do
            {
                Console.WriteLine("Please Enter Exam Type 1---->  For Practical, 2---->  2 For Final");
            }
            while (!(int.TryParse(Console.ReadLine() , out examType) && (examType is 1 or 2)));
            do
            {
                Console.WriteLine("Please Enter Exam time ");
            }
            while (!(int.TryParse(Console.ReadLine() , out time) && (time > 0)));
            do
            {
                Console.WriteLine("Please Enter Exam number Of Question ");
            }
            while (!(int.TryParse(Console.ReadLine() , out numberOfQuestion) && (numberOfQuestion > 0)));
            if (examType == 1)
            {
                SubjectExam = new PracticalExam(time , numberOfQuestion);
            }
            else
            {
                SubjectExam = new FinalExam(time, numberOfQuestion);
            }
            Console.Clear();
            SubjectExam.CreateListOfQuestion();
        }
    }
}
