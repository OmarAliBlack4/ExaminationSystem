using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public int NumOfQuestion { get; set; }
        public Questions[] Questions { get; set; }

        protected Exam(int time , int NumOfQuestion)
        {
            this.Time = time;
            this.NumOfQuestion = NumOfQuestion;

        }
        public abstract void ShowExam();
        public abstract void CreateListOfQuestion();
    }
}
