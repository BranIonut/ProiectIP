/**************************************************************************
 *                                                                        *
 *  File:        ResultsForm.cs                                           *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Metoda de afisare a rezultatului obtinut in quiz         *
 *                                                                        *
 *  Această aplicație a fost realizată de patru studenți ai Facultății de *
 *  Automatică și Calculatoare, în cadrul materiei Ingineria Programării. *
 *  Este oferită ca software liber, conform licenței GNU GPL.             *
 *  Poate fi redistribuită și/sau modificată, dar fără nicio garanție,    *
 *  nici măcar pentru adecvarea la un scop anume.                         *
 *                                                                        *
 **************************************************************************/
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
