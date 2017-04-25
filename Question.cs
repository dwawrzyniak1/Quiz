using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamianWawrzyniakLab1
{
    class Question
    {
        public string question;
        public string[] answers;
        public string rightAnswer;

        public Question(string question, string[] answers)
        {
            this.question = question;
            this.answers = answers;
            rightAnswer = answers[answers.Length - 1];
        }
    }
}
