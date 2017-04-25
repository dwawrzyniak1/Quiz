using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamianWawrzyniakLab1
{
    class Quiz
    {
        // Tablica przechowująca bazę pytań
        public Question[] questionBase;
        // Tablica wczytanych linii z tekstu
        string[] readFromFile;

        /// <summary>
        /// Tworzenie nowego quizu; 
        /// </summary>
        /// <param name="fileName"></param>
        public Quiz(string fileName)
        {
            try
            {
                readFromFile = System.IO.File.ReadAllLines(fileName);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            questionBase = new Question[readFromFile.Length / 2];
            createQuestionBase();
        }
        /// <summary>
        /// Przenosi dane z pliku tekstowego do bazy pytań
        /// </summary>
        private void createQuestionBase()
        {
            string question = "";
            string[] answers;
            int questionBaseIndex = 0;
            for (int i = 0; i < readFromFile.Length; i++)
            {
                if (i % 2 == 0) question = readFromFile[i];
                if (i % 2 == 1)
                {
                    answers = readFromFile[i].Split(',');
                    questionBase[questionBaseIndex++] = new Question(question, answers);
                }
            }
        }
    }
}
