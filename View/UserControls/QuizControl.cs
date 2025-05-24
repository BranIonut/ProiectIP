using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto.UserControls
{
    public partial class QuizControl : UserControl
    {
        public event EventHandler<AnswerEventArgs> NextQuestionClicked;
        public event EventHandler PreviousQuestionClicked;
        public event EventHandler AbortQuizClicked;
        public QuizControl()
        {
            InitializeComponent();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var selectedAnswers = new List<int>();

            if (answerCheckBox1.Checked) selectedAnswers.Add(0);
            if (answerCheckBox2.Checked) selectedAnswers.Add(1);
            if (answerCheckBox3.Checked) selectedAnswers.Add(2);
            if (answerCheckBox4.Checked) selectedAnswers.Add(3);

            NextQuestionClicked?.Invoke(this, new AnswerEventArgs(selectedAnswers));
        }

        private void prevQuestionButton_Click(object sender, EventArgs e)
        {
            PreviousQuestionClicked?.Invoke(this, EventArgs.Empty);
        }

        private void abortQuizButton_Click(object sender, EventArgs e)
        {
            AbortQuizClicked?.Invoke(this, EventArgs.Empty);
        }

        public void LoadQuestion(Question question)
        {
            questionLabel.Text = question.question;
            answerCheckBox1.Text = question.answers[0];
            answerCheckBox2.Text = question.answers[1];
            answerCheckBox3.Text = question.answers[2];
            //answerCheckBox4.Text = question.answers[3];

            answerCheckBox1.Checked = false;
            answerCheckBox2.Checked = false;
            answerCheckBox3.Checked = false;
            answerCheckBox4.Checked = false;
        }
    }

    public class AnswerEventArgs : EventArgs
    {
        public List<int> SelectedAnswers { get; }

        public AnswerEventArgs(List<int> selectedAnswers)
        {
            SelectedAnswers = selectedAnswers;
        }
    }
}
