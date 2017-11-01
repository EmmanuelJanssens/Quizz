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
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.rbAnswerOne = new System.Windows.Forms.RadioButton();
            this.rbAnswerTwo = new System.Windows.Forms.RadioButton();
            this.rbAnswerThree = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cmdQuitGame = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
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
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.rbAnswerThree);
            this.grpQuestion.Controls.Add(this.rbAnswerTwo);
            this.grpQuestion.Controls.Add(this.rbAnswerOne);
            this.grpQuestion.Location = new System.Drawing.Point(47, 82);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(200, 100);
            this.grpQuestion.TabIndex = 1;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Question 1";
            // 
            // rbAnswerOne
            // 
            this.rbAnswerOne.AutoSize = true;
            this.rbAnswerOne.Location = new System.Drawing.Point(6, 21);
            this.rbAnswerOne.Name = "rbAnswerOne";
            this.rbAnswerOne.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerOne.TabIndex = 0;
            this.rbAnswerOne.TabStop = true;
            this.rbAnswerOne.Text = "radioButton1";
            this.rbAnswerOne.UseVisualStyleBackColor = true;
            // 
            // rbAnswerTwo
            // 
            this.rbAnswerTwo.AutoSize = true;
            this.rbAnswerTwo.Location = new System.Drawing.Point(6, 44);
            this.rbAnswerTwo.Name = "rbAnswerTwo";
            this.rbAnswerTwo.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerTwo.TabIndex = 1;
            this.rbAnswerTwo.TabStop = true;
            this.rbAnswerTwo.Text = "radioButton2";
            this.rbAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // rbAnswerThree
            // 
            this.rbAnswerThree.AutoSize = true;
            this.rbAnswerThree.Location = new System.Drawing.Point(6, 67);
            this.rbAnswerThree.Name = "rbAnswerThree";
            this.rbAnswerThree.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerThree.TabIndex = 2;
            this.rbAnswerThree.TabStop = true;
            this.rbAnswerThree.Text = "radioButton3";
            this.rbAnswerThree.UseVisualStyleBackColor = true;
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.cmdQuitGame);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.lblCategory);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.RadioButton rbAnswerThree;
        private System.Windows.Forms.RadioButton rbAnswerTwo;
        private System.Windows.Forms.RadioButton rbAnswerOne;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button cmdQuitGame;
    }
}