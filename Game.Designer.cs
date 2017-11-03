namespace Quizz
{
    partial class Game
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.rbAnswerThree = new System.Windows.Forms.RadioButton();
            this.rbAnswerTwo = new System.Windows.Forms.RadioButton();
            this.rbAnswerOne = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cmdQuitGame = new System.Windows.Forms.Button();
            this.cmdNextTest = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(50, 52);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categorie";
            // 
            // rbAnswerThree
            // 
            this.rbAnswerThree.AutoCheck = false;
            this.rbAnswerThree.AutoSize = true;
            this.rbAnswerThree.Location = new System.Drawing.Point(47, 177);
            this.rbAnswerThree.Name = "rbAnswerThree";
            this.rbAnswerThree.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerThree.TabIndex = 2;
            this.rbAnswerThree.TabStop = true;
            this.rbAnswerThree.Text = "radioButton3";
            this.rbAnswerThree.UseVisualStyleBackColor = true;
            // 
            // rbAnswerTwo
            // 
            this.rbAnswerTwo.AutoCheck = false;
            this.rbAnswerTwo.AutoSize = true;
            this.rbAnswerTwo.Location = new System.Drawing.Point(47, 154);
            this.rbAnswerTwo.Name = "rbAnswerTwo";
            this.rbAnswerTwo.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerTwo.TabIndex = 1;
            this.rbAnswerTwo.TabStop = true;
            this.rbAnswerTwo.Text = "radioButton2";
            this.rbAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // rbAnswerOne
            // 
            this.rbAnswerOne.AutoCheck = false;
            this.rbAnswerOne.AutoSize = true;
            this.rbAnswerOne.Location = new System.Drawing.Point(47, 131);
            this.rbAnswerOne.Name = "rbAnswerOne";
            this.rbAnswerOne.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerOne.TabIndex = 0;
            this.rbAnswerOne.TabStop = true;
            this.rbAnswerOne.Text = "radioButton1";
            this.rbAnswerOne.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(273, 74);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(151, 108);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "10";
            // 
            // cmdQuitGame
            // 
            this.cmdQuitGame.Location = new System.Drawing.Point(349, 226);
            this.cmdQuitGame.Name = "cmdQuitGame";
            this.cmdQuitGame.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitGame.TabIndex = 3;
            this.cmdQuitGame.Text = "Quitter";
            this.cmdQuitGame.UseVisualStyleBackColor = true;
            // 
            // cmdNextTest
            // 
            this.cmdNextTest.Location = new System.Drawing.Point(47, 226);
            this.cmdNextTest.Name = "cmdNextTest";
            this.cmdNextTest.Size = new System.Drawing.Size(75, 23);
            this.cmdNextTest.TabIndex = 4;
            this.cmdNextTest.Text = "next";
            this.cmdNextTest.UseVisualStyleBackColor = true;
            this.cmdNextTest.Click += new System.EventHandler(this.cmdNextTest_Click);
            // 
            // countDown
            // 
            this.countDown.Interval = 1000;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(50, 96);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rbAnswerThree);
            this.Controls.Add(this.cmdNextTest);
            this.Controls.Add(this.rbAnswerTwo);
            this.Controls.Add(this.cmdQuitGame);
            this.Controls.Add(this.rbAnswerOne);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCategory);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton rbAnswerThree;
        private System.Windows.Forms.RadioButton rbAnswerTwo;
        private System.Windows.Forms.RadioButton rbAnswerOne;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button cmdQuitGame;
        private System.Windows.Forms.Button cmdNextTest;
        private System.Windows.Forms.Timer countDown;
        private System.Windows.Forms.Label lblQuestion;
    }
}