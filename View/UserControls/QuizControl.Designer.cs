namespace ChestionarAuto.UserControls
{
    partial class QuizControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.answerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox2 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox3 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox4 = new System.Windows.Forms.CheckBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.prevQuestionButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.correctAnswLabel = new System.Windows.Forms.Label();
            this.wrongAnswLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.abortQuizButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // answerCheckBox1
            // 
            this.answerCheckBox1.AutoSize = true;
            this.answerCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox1.Location = new System.Drawing.Point(28, 399);
            this.answerCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.answerCheckBox1.Name = "answerCheckBox1";
            this.answerCheckBox1.Size = new System.Drawing.Size(131, 29);
            this.answerCheckBox1.TabIndex = 1;
            this.answerCheckBox1.Text = "checkBox1";
            this.answerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // answerCheckBox2
            // 
            this.answerCheckBox2.AutoSize = true;
            this.answerCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox2.Location = new System.Drawing.Point(28, 453);
            this.answerCheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.answerCheckBox2.Name = "answerCheckBox2";
            this.answerCheckBox2.Size = new System.Drawing.Size(131, 29);
            this.answerCheckBox2.TabIndex = 2;
            this.answerCheckBox2.Text = "checkBox2";
            this.answerCheckBox2.UseVisualStyleBackColor = true;
            // 
            // answerCheckBox3
            // 
            this.answerCheckBox3.AutoSize = true;
            this.answerCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox3.Location = new System.Drawing.Point(375, 399);
            this.answerCheckBox3.Margin = new System.Windows.Forms.Padding(4);
            this.answerCheckBox3.Name = "answerCheckBox3";
            this.answerCheckBox3.Size = new System.Drawing.Size(131, 29);
            this.answerCheckBox3.TabIndex = 3;
            this.answerCheckBox3.Text = "checkBox3";
            this.answerCheckBox3.UseVisualStyleBackColor = true;
            // 
            // answerCheckBox4
            // 
            this.answerCheckBox4.AutoSize = true;
            this.answerCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox4.Location = new System.Drawing.Point(375, 453);
            this.answerCheckBox4.Margin = new System.Windows.Forms.Padding(4);
            this.answerCheckBox4.Name = "answerCheckBox4";
            this.answerCheckBox4.Size = new System.Drawing.Size(131, 29);
            this.answerCheckBox4.TabIndex = 4;
            this.answerCheckBox4.Text = "checkBox4";
            this.answerCheckBox4.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(759, 332);
            this.nextQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(151, 42);
            this.nextQuestionButton.TabIndex = 5;
            this.nextQuestionButton.Text = "Next";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // prevQuestionButton
            // 
            this.prevQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevQuestionButton.Location = new System.Drawing.Point(759, 399);
            this.prevQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevQuestionButton.Name = "prevQuestionButton";
            this.prevQuestionButton.Size = new System.Drawing.Size(151, 41);
            this.prevQuestionButton.TabIndex = 6;
            this.prevQuestionButton.Text = "Prev";
            this.prevQuestionButton.UseVisualStyleBackColor = true;
            this.prevQuestionButton.Click += new System.EventHandler(this.prevQuestionButton_Click);
            // 
            // correctAnswLabel
            // 
            this.correctAnswLabel.AutoSize = true;
            this.correctAnswLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswLabel.ForeColor = System.Drawing.Color.Green;
            this.correctAnswLabel.Location = new System.Drawing.Point(752, 39);
            this.correctAnswLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correctAnswLabel.Name = "correctAnswLabel";
            this.correctAnswLabel.Size = new System.Drawing.Size(112, 31);
            this.correctAnswLabel.TabIndex = 7;
            this.correctAnswLabel.Text = "Correct:";
            // 
            // wrongAnswLabel
            // 
            this.wrongAnswLabel.AutoSize = true;
            this.wrongAnswLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAnswLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongAnswLabel.Location = new System.Drawing.Point(752, 92);
            this.wrongAnswLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongAnswLabel.Name = "wrongAnswLabel";
            this.wrongAnswLabel.Size = new System.Drawing.Size(101, 31);
            this.wrongAnswLabel.TabIndex = 8;
            this.wrongAnswLabel.Text = "Wrong:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.timerLabel.Location = new System.Drawing.Point(752, 149);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(91, 31);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "Timer:";
            // 
            // abortQuizButton
            // 
            this.abortQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortQuizButton.Location = new System.Drawing.Point(759, 464);
            this.abortQuizButton.Margin = new System.Windows.Forms.Padding(4);
            this.abortQuizButton.Name = "abortQuizButton";
            this.abortQuizButton.Size = new System.Drawing.Size(151, 38);
            this.abortQuizButton.TabIndex = 10;
            this.abortQuizButton.Text = "Abort";
            this.abortQuizButton.UseVisualStyleBackColor = true;
            this.abortQuizButton.Click += new System.EventHandler(this.abortQuizButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(28, 332);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(553, 29);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "Ce trebuie să faceți când întâlniți semnul «STOP»?";
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.abortQuizButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.wrongAnswLabel);
            this.Controls.Add(this.correctAnswLabel);
            this.Controls.Add(this.prevQuestionButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.answerCheckBox4);
            this.Controls.Add(this.answerCheckBox3);
            this.Controls.Add(this.answerCheckBox2);
            this.Controls.Add(this.answerCheckBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(1031, 524);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox answerCheckBox1;
        private System.Windows.Forms.CheckBox answerCheckBox2;
        private System.Windows.Forms.CheckBox answerCheckBox3;
        private System.Windows.Forms.CheckBox answerCheckBox4;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button prevQuestionButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label correctAnswLabel;
        private System.Windows.Forms.Label wrongAnswLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button abortQuizButton;
        private System.Windows.Forms.Label questionLabel;
    }
}
