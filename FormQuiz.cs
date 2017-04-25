using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianWawrzyniakLab1
{
    public partial class FormQuiz : Form
    {
        //Zmienna określająca ilość czasu (w sekundach) na każde pytanie
        int remainingTime = 10;

        //Zmienna zawierająca nazwę pliku, przydatna przy możliwości zmiany quizu
        static string fileName = "bazaPytan.txt";

        //Tworzymy nowy quiz wczytując dane do niego z pliku tekstowego
        Quiz newQuiz = new Quiz(fileName);

        //Indeks pytania w tablicy pytań (klasa Quiz)
        int questionNumber;

        //Zmienna tekstowa, której przypisujemy poprawną odpowiedź w danym pytaniu
        string rightAnswer;

        public FormQuiz()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klikając w przycisk Start rozpoczynamy Quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            questionTimeTimer.Start();
            StartQuiz();
        }
        /// <summary>
        /// Ustawiamy indeks pytań na 0, wczytujemy pierwsze pytanie oraz ustawiamy właściwości naszego Progress Bar
        /// </summary>
        private void StartQuiz()
        {
            questionNumber = 0;
            ChangeQuestion();
            ProgressBarSettings();
        }
        /// <summary>
        /// Za każdą poprawną odpowiedź otrzymujemy 1 punkt; Maksymalna ilość punktów - długość tablicy przechowującej pytania (questionBase - klasa Quiz)
        /// </summary>
        private void ProgressBarSettings()
        {
            progressBarScore.Step = 1;
            progressBarScore.Maximum = newQuiz.questionBase.Length;
            progressBarScore.Value = 0;
        }
        /// <summary>
        /// questionTimeTimer ma za zadanie odliczać czas na odpowiedź - 1 takt zegara 1 sekunda; Gdy w ciągu 10 sekund nie nastąpi odpowiedź następuje zmiana pytania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void questionTimeTimer_Tick(object sender, EventArgs e)
        {
            remainingTimeLabel.Text = null;
            if (remainingTime >= 0) remainingTimeLabel.Text += remainingTime--;
            else
            {
                if (questionNumber < newQuiz.questionBase.Length) questionNumber++;
                ChangeQuestion();
            }
        }
        /// <summary>
        /// Zatrzymuje odliczanie czasu do końca pytania; Jeśli w bazie pytań są jeszcze jakieś pytania następuje zmiana pytania,
        /// w przeciwnym wypadku następuje koniec quizu.
        /// </summary>
        private void ChangeQuestion()
        {
            questionTimeTimer.Stop();
            if(questionNumber < newQuiz.questionBase.Length)
            {
                questionLabel.Text = newQuiz.questionBase[questionNumber].question;
                buttonAnswerA.Text = newQuiz.questionBase[questionNumber].answers[0];
                buttonAnswerB.Text = newQuiz.questionBase[questionNumber].answers[1];
                buttonAnswerC.Text = newQuiz.questionBase[questionNumber].answers[2];
                buttonAnswerD.Text = newQuiz.questionBase[questionNumber].answers[3];
                rightAnswer = newQuiz.questionBase[questionNumber].rightAnswer;
                remainingTime = 10;
                questionTimeTimer.Start();
            }
            else
            {
                EndOfQuiz();
            }        
        }
        /// <summary>
        /// Wyświetla nasz wynik w wykonanym quizie i resetuje ustawienia FormQuiz
        /// </summary>
        private void EndOfQuiz()
        {
            double percantegeScore = (progressBarScore.Value * 100) / progressBarScore.Maximum;
            if (percantegeScore > 90) MessageBox.Show("Doskonale, uzyskales " + percantegeScore + "%");
            else if (percantegeScore > 70) MessageBox.Show("Dobra robota, uzyskales " + percantegeScore + "%");
            else if (percantegeScore > 50) MessageBox.Show("Nie jest zle, uzyskales " + percantegeScore + "%");
            else MessageBox.Show("Nie najlepiej, uzyskales " + percantegeScore + "%");
            ResetQuiz();
        }
        /// <summary>
        /// Resetuje ustawienia quizu do początkowych
        /// </summary>
        private void ResetQuiz()
        {
            questionLabel.Text = "Question Label";
            buttonAnswerA.Text = "answer A";
            buttonAnswerB.Text = "answer B";
            buttonAnswerC.Text = "answer C";
            buttonAnswerD.Text = "answer D";
            remainingTimeLabel.Text = "time";
            progressBarScore.Value = 0;
        }
        /// <summary>
        /// Sprawdza czy odpowiedź umieszczona na danym przycisku jest poprawna; Wywołuje metody Score lub WrongAnswer w zależności od poprawności odpowiedzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnswerA_Click(object sender, EventArgs e)
        {
            if (buttonAnswerA.Text == rightAnswer) Score();
            else if(rightAnswer != null) WrongAnswer();
        }
        /// <summary>
        /// Pokazuje, że odpowiedź była błędna poprzez zmianę tła pola IsAnswerGoodLabel na czerwony, zmienia pytanie na następne
        /// </summary>
        private void WrongAnswer()
        {
            IsAnswerGoodLabel.BackColor = Color.Red;
            IsAnswerGoodTimer.Start();
            questionNumber++;
            ChangeQuestion();
        }
        /// <summary>
        /// Pokazuje, że odpowiedź jest poprawna poprzez zmianę tła pola IsAnswerGoodLabel na zielony (metoda GoodAnswer), zmienia pytanie na następne
        /// </summary>
        private void Score()
        {
            GoodAnswer();
            questionNumber++;
            ChangeQuestion();
        }

        private void GoodAnswer()
        {
            progressBarScore.PerformStep();
            IsAnswerGoodLabel.BackColor = Color.Green;
            IsAnswerGoodTimer.Start();
        }

        private void buttonAnswerB_Click(object sender, EventArgs e)
        {
            if (buttonAnswerB.Text == rightAnswer) Score();
            else if (rightAnswer != null) WrongAnswer();
        }

        private void buttonAnswerC_Click(object sender, EventArgs e)
        {
            if (buttonAnswerC.Text == rightAnswer) Score();
            else if (rightAnswer != null) WrongAnswer();
        }

        private void buttonAnswerD_Click(object sender, EventArgs e)
        {
            if (buttonAnswerD.Text == rightAnswer) Score();
            else if (rightAnswer != null) WrongAnswer();
        }
        /// <summary>
        /// Wprowadzanie z pliku nowej bazy pytań do Quizu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilename_TextChanged(object sender, EventArgs e)
        {
            fileName = textBoxFilename.Text;
            newQuiz = new Quiz(fileName);
        }

        /// <summary>
        /// Jednorazowy takt zegara - powrót koloru tła IsAnswerGoodLabel do wartości początkowej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
                       
        private void IsAnswerGoodTimer_Tick(object sender, EventArgs e)
        {
            IsAnswerGoodTimer.Stop();
            IsAnswerGoodLabel.BackColor = FormQuiz.DefaultBackColor;
        }
    }
}
