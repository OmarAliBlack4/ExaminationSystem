using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Answer(int id , string text)
        {
            this.Id = id;
            this.Text = text;
        }
        public Answer()
        {
            
        }
        public override string ToString()
        {
            return $"AnswerID : {Id} , AnswerText : {Text}";
        }
    }
}
