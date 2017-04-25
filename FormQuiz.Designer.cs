namespace DamianWawrzyniakLab1
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.questionTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.progressBarScore = new System.Windows.Forms.ProgressBar();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.buttonAnswerA = new System.Windows.Forms.Button();
            this.buttonAnswerB = new System.Windows.Forms.Button();
            this.buttonAnswerC = new System.Windows.Forms.Button();
            this.buttonAnswerD = new System.Windows.Forms.Button();
            this.labelRemainingTimePoint = new System.Windows.Forms.Label();
            this.IsAnswerGoodLabel = new System.Windows.Forms.Label();
            this.IsAnswerGoodTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remainingTimeLabel.Location = new System.Drawing.Point(237, 13);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.remainingTimeLabel.TabIndex = 0;
            this.remainingTimeLabel.Text = "time";
            // 
            // questionTimeTimer
            // 
            this.questionTimeTimer.Interval = 1000;
            this.questionTimeTimer.Tick += new System.EventHandler(this.questionTimeTimer_Tick);
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Location = new System.Drawing.Point(15, 8);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.buttonStartQuiz.TabIndex = 1;
            this.buttonStartQuiz.Text = "Start";
            this.buttonStartQuiz.UseVisualStyleBackColor = true;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // progressBarScore
            // 
            this.progressBarScore.Location = new System.Drawing.Point(121, 226);
            this.progressBarScore.Name = "progressBarScore";
            this.progressBarScore.Size = new System.Drawing.Size(151, 23);
            this.progressBarScore.TabIndex = 2;
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(13, 228);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilename.TabIndex = 3;
            this.textBoxFilename.Text = "wpisz nazwę pliku";
            this.textBoxFilename.TextChanged += new System.EventHandler(this.textBoxFilename_TextChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(15, 38);
            this.questionLabel.MaximumSize = new System.Drawing.Size(250, 60);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(121, 18);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "Question Label";
            // 
            // buttonAnswerA
            // 
            this.buttonAnswerA.Location = new System.Drawing.Point(15, 99);
            this.buttonAnswerA.Name = "buttonAnswerA";
            this.buttonAnswerA.Size = new System.Drawing.Size(100, 50);
            this.buttonAnswerA.TabIndex = 5;
            this.buttonAnswerA.Text = "answer A";
            this.buttonAnswerA.UseVisualStyleBackColor = true;
            this.buttonAnswerA.Click += new System.EventHandler(this.buttonAnswerA_Click);
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.Location = new System.Drawing.Point(121, 99);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(100, 50);
            this.buttonAnswerB.TabIndex = 6;
            this.buttonAnswerB.Text = "answer B";
            this.buttonAnswerB.UseVisualStyleBackColor = true;
            this.buttonAnswerB.Click += new System.EventHandler(this.buttonAnswerB_Click);
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.Location = new System.Drawing.Point(13, 155);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(100, 50);
            this.buttonAnswerC.TabIndex = 7;
            this.buttonAnswerC.Text = "answer C";
            this.buttonAnswerC.UseVisualStyleBackColor = true;
            this.buttonAnswerC.Click += new System.EventHandler(this.buttonAnswerC_Click);
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.Location = new System.Drawing.Point(121, 155);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(100, 50);
            this.buttonAnswerD.TabIndex = 8;
            this.buttonAnswerD.Text = "answer D";
            this.buttonAnswerD.UseVisualStyleBackColor = true;
            this.buttonAnswerD.Click += new System.EventHandler(this.buttonAnswerD_Click);
            // 
            // labelRemainingTimePoint
            // 
            this.labelRemainingTimePoint.AutoSize = true;
            this.labelRemainingTimePoint.Location = new System.Drawing.Point(120, 13);
            this.labelRemainingTimePoint.Name = "labelRemainingTimePoint";
            this.labelRemainingTimePoint.Size = new System.Drawing.Size(101, 13);
            this.labelRemainingTimePoint.TabIndex = 10;
            this.labelRemainingTimePoint.Text = "czas na odpowiedz:";
            // 
            // IsAnswerGoodLabel
            // 
            this.IsAnswerGoodLabel.AutoSize = true;
            this.IsAnswerGoodLabel.Location = new System.Drawing.Point(232, 99);
            this.IsAnswerGoodLabel.Name = "IsAnswerGoodLabel";
            this.IsAnswerGoodLabel.Size = new System.Drawing.Size(40, 13);
            this.IsAnswerGoodLabel.TabIndex = 11;
            this.IsAnswerGoodLabel.Text = "           ";
            // 
            // IsAnswerGoodTimer
            // 
            this.IsAnswerGoodTimer.Interval = 500;
            this.IsAnswerGoodTimer.Tick += new System.EventHandler(this.IsAnswerGoodTimer_Tick);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.IsAnswerGoodLabel);
            this.Controls.Add(this.labelRemainingTimePoint);
            this.Controls.Add(this.buttonAnswerD);
            this.Controls.Add(this.buttonAnswerC);
            this.Controls.Add(this.buttonAnswerB);
            this.Controls.Add(this.buttonAnswerA);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.progressBarScore);
            this.Controls.Add(this.buttonStartQuiz);
            this.Controls.Add(this.remainingTimeLabel);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Timer questionTimeTimer;
        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.ProgressBar progressBarScore;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button buttonAnswerA;
        private System.Windows.Forms.Button buttonAnswerB;
        private System.Windows.Forms.Button buttonAnswerC;
        private System.Windows.Forms.Button buttonAnswerD;
        private System.Windows.Forms.Label labelRemainingTimePoint;
        private System.Windows.Forms.Label IsAnswerGoodLabel;
        private System.Windows.Forms.Timer IsAnswerGoodTimer;
    }
}