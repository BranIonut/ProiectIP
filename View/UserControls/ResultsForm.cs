using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    public partial class ResultsForm : Form
    {

        public ResultsForm(int correctAnswers, int wrongAnswers, string quizState)
        {
            InitializeComponent();

            correctAnswersLabel.Text = $"Răspunsuri corecte: {correctAnswers}";
            wrongAnswersLabel.Text = $"Răspunsuri greșite: {wrongAnswers}";
            quizStateLabel.Text = $"{quizState}";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
