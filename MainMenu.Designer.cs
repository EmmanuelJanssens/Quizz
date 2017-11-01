namespace Quizz
{
    partial class MainMenu
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
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.cmdScoreBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(0, 0);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.ScrollAlwaysVisible = true;
            this.lstCategory.Size = new System.Drawing.Size(120, 261);
            this.lstCategory.TabIndex = 0;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(123, 63);
            this.cmdPlay.Margin = new System.Windows.Forms.Padding(0);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(160, 60);
            this.cmdPlay.TabIndex = 1;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // cmdScoreBoard
            // 
            this.cmdScoreBoard.Location = new System.Drawing.Point(123, 133);
            this.cmdScoreBoard.Margin = new System.Windows.Forms.Padding(0);
            this.cmdScoreBoard.Name = "cmdScoreBoard";
            this.cmdScoreBoard.Size = new System.Drawing.Size(160, 60);
            this.cmdScoreBoard.TabIndex = 2;
            this.cmdScoreBoard.Text = "Scores";
            this.cmdScoreBoard.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdScoreBoard);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.lstCategory);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Button cmdScoreBoard;
    }
}

