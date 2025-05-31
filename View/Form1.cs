/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Initializarea componentelor                              *
 *                                                                        *
 *  Această aplicație a fost realizată de patru studenți ai Facultății de *
 *  Automatică și Calculatoare, în cadrul materiei Ingineria Programării. *
 *  Este oferită ca software liber, conform licenței GNU GPL.             *
 *  Poate fi redistribuită și/sau modificată, dar fără nicio garanție,    *
 *  nici măcar pentru adecvarea la un scop anume.                         *
 *                                                                        *
 **************************************************************************/
using ChestionarAuto.UserControls;
using System.Windows.Forms;

namespace ChestionarAuto
{
    public partial class Form1 : Form
    {
        private Panel containerPanel;
        private Button btnSwitch;
        private bool isPanel1Visible = true;

        public Form1()
        {
            InitializeComponent();
            var login = new LogInUserControl();
        }

        public void LoadUserControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
    }
}
