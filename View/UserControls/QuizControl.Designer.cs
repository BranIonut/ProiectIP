namespace ChestionarAuto
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
            this.quizPictureBox = new System.Windows.Forms.PictureBox();
            this.answerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox2 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox3 = new System.Windows.Forms.CheckBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.correctAnswLabel = new System.Windows.Forms.Label();
            this.wrongAnswLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.abortQuizButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quizPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quizPictureBox
            // 
            this.quizPictureBox.Location = new System.Drawing.Point(21, 32);
            this.quizPictureBox.Name = "quizPictureBox";
            this.quizPictureBox.Size = new System.Drawing.Size(511, 213);
            this.quizPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quizPictureBox.TabIndex = 0;
            this.quizPictureBox.TabStop = false;
            // 
            // answerCheckBox1
            // 
            this.answerCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox1.Location = new System.Drawing.Point(21, 307);
            this.answerCheckBox1.Name = "answerCheckBox1";
            this.answerCheckBox1.Size = new System.Drawing.Size(579, 44);
            this.answerCheckBox1.TabIndex = 1;
            this.answerCheckBox1.Text = "checkBox1";
            this.answerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // answerCheckBox2
            // 
            this.answerCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox2.Location = new System.Drawing.Point(21, 368);
            this.answerCheckBox2.Name = "answerCheckBox2";
            this.answerCheckBox2.Size = new System.Drawing.Size(579, 44);
            this.answerCheckBox2.TabIndex = 2;
            this.answerCheckBox2.Text = "checkBox2";
            this.answerCheckBox2.UseVisualStyleBackColor = true;
            // 
            // answerCheckBox3
            // 
            this.answerCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox3.Location = new System.Drawing.Point(21, 422);
            this.answerCheckBox3.Name = "answerCheckBox3";
            this.answerCheckBox3.Size = new System.Drawing.Size(579, 44);
            this.answerCheckBox3.TabIndex = 3;
            this.answerCheckBox3.Text = "checkBox3";
            this.answerCheckBox3.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(629, 331);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(113, 34);
            this.nextQuestionButton.TabIndex = 5;
            this.nextQuestionButton.Text = "Next";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // correctAnswLabel
            // 
            this.correctAnswLabel.AutoSize = true;
            this.correctAnswLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswLabel.ForeColor = System.Drawing.Color.Green;
            this.correctAnswLabel.Location = new System.Drawing.Point(564, 32);
            this.correctAnswLabel.Name = "correctAnswLabel";
            this.correctAnswLabel.Size = new System.Drawing.Size(88, 25);
            this.correctAnswLabel.TabIndex = 7;
            this.correctAnswLabel.Text = "Correct:";
            // 
            // wrongAnswLabel
            // 
            this.wrongAnswLabel.AutoSize = true;
            this.wrongAnswLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAnswLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongAnswLabel.Location = new System.Drawing.Point(564, 75);
            this.wrongAnswLabel.Name = "wrongAnswLabel";
            this.wrongAnswLabel.Size = new System.Drawing.Size(81, 25);
            this.wrongAnswLabel.TabIndex = 8;
            this.wrongAnswLabel.Text = "Wrong:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.timerLabel.Location = new System.Drawing.Point(564, 121);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(72, 25);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "Timer:";
            // 
            // abortQuizButton
            // 
            this.abortQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortQuizButton.Location = new System.Drawing.Point(629, 381);
            this.abortQuizButton.Name = "abortQuizButton";
            this.abortQuizButton.Size = new System.Drawing.Size(113, 31);
            this.abortQuizButton.TabIndex = 10;
            this.abortQuizButton.Text = "Abort";
            this.abortQuizButton.UseVisualStyleBackColor = true;
            this.abortQuizButton.Click += new System.EventHandler(this.abortQuizButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(17, 248);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(583, 56);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "Ce trebuie să faceți când întâlniți semnul «STOP»?";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(629, 282);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(113, 32);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.abortQuizButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.wrongAnswLabel);
            this.Controls.Add(this.correctAnswLabel);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.answerCheckBox3);
            this.Controls.Add(this.answerCheckBox2);
            this.Controls.Add(this.answerCheckBox1);
            this.Controls.Add(this.quizPictureBox);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(773, 520);
            ((System.ComponentModel.ISupportInitialize)(this.quizPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox quizPictureBox;
        private System.Windows.Forms.CheckBox answerCheckBox1;
        private System.Windows.Forms.CheckBox answerCheckBox2;
        private System.Windows.Forms.CheckBox answerCheckBox3;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label correctAnswLabel;
        private System.Windows.Forms.Label wrongAnswLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button abortQuizButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button helpButton;
    }
}
