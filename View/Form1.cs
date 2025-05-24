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
