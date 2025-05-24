namespace ChestionarAuto
{
    partial class ResultsForm
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
            this.correctAnswersLabel = new System.Windows.Forms.Label();
            this.wrongAnswersLabel = new System.Windows.Forms.Label();
            this.quizStateLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.AutoSize = true;
            this.correctAnswersLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.correctAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswersLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.correctAnswersLabel.Location = new System.Drawing.Point(53, 153);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(245, 29);
            this.correctAnswersLabel.TabIndex = 0;
            this.correctAnswersLabel.Text = "Răspunsuri corecte: ";
            // 
            // wrongAnswersLabel
            // 
            this.wrongAnswersLabel.AutoSize = true;
            this.wrongAnswersLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.wrongAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAnswersLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongAnswersLabel.Location = new System.Drawing.Point(463, 153);
            this.wrongAnswersLabel.Name = "wrongAnswersLabel";
            this.wrongAnswersLabel.Size = new System.Drawing.Size(238, 29);
            this.wrongAnswersLabel.TabIndex = 0;
            this.wrongAnswersLabel.Text = "Răspunsuri greșite: ";
            // 
            // quizStateLabel
            // 
            this.quizStateLabel.AutoSize = true;
            this.quizStateLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.quizStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizStateLabel.Location = new System.Drawing.Point(330, 72);
            this.quizStateLabel.Name = "quizStateLabel";
            this.quizStateLabel.Size = new System.Drawing.Size(107, 39);
            this.quizStateLabel.TabIndex = 0;
            this.quizStateLabel.Text = "status";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(337, 300);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 43);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.quizStateLabel);
            this.Controls.Add(this.wrongAnswersLabel);
            this.Controls.Add(this.correctAnswersLabel);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctAnswersLabel;
        private System.Windows.Forms.Label wrongAnswersLabel;
        private System.Windows.Forms.Label quizStateLabel;
        private System.Windows.Forms.Button okButton;
    }
}