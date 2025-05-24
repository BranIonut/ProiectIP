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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
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
            this.pictureBox1.Location = new System.Drawing.Point(21, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(21, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(21, 368);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(281, 324);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(281, 368);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(569, 270);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(113, 34);
            this.nextQuestionButton.TabIndex = 5;
            this.nextQuestionButton.Text = "Next";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // prevQuestionButton
            // 
            this.prevQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevQuestionButton.Location = new System.Drawing.Point(569, 324);
            this.prevQuestionButton.Name = "prevQuestionButton";
            this.prevQuestionButton.Size = new System.Drawing.Size(113, 33);
            this.prevQuestionButton.TabIndex = 6;
            this.prevQuestionButton.Text = "Prev";
            this.prevQuestionButton.UseVisualStyleBackColor = true;
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
            this.abortQuizButton.Location = new System.Drawing.Point(569, 377);
            this.abortQuizButton.Name = "abortQuizButton";
            this.abortQuizButton.Size = new System.Drawing.Size(113, 31);
            this.abortQuizButton.TabIndex = 10;
            this.abortQuizButton.Text = "Abort";
            this.abortQuizButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(21, 270);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(430, 24);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "Ce trebuie să faceți când întâlniți semnul «STOP»?";
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.abortQuizButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.wrongAnswLabel);
            this.Controls.Add(this.correctAnswLabel);
            this.Controls.Add(this.prevQuestionButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(773, 426);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
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
