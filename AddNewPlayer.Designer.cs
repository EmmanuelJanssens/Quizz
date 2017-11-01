namespace Quizz
{
    partial class AddNewPlayer
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
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPseudo
            // 
            this.txtPseudo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPseudo.Location = new System.Drawing.Point(12, 28);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(200, 20);
            this.txtPseudo.TabIndex = 0;
            this.txtPseudo.TextChanged += new System.EventHandler(this.txtPseudo_TextChanged);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(12, 67);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(80, 30);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "Valider";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(132, 67);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 30);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(12, 9);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(164, 13);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Inserez votre pseudo : Disponible";
            // 
            // AddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtPseudo);
            this.MaximumSize = new System.Drawing.Size(250, 150);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "AddNewPlayer";
            this.Text = "AddNewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblPseudo;
    }
}