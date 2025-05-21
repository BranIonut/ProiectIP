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
            LoadLoginControl();
        }

        private void LoadLoginControl()
        {
            var login = new LogInUserControl();
            login.DashBoardRequested += (s, e) => LoadUserDashboardControl();
            login.SignUpRequested += (s, e) => LoadSignUpControl();
            LoadUserControl(login);
        }

        private void LoadSignUpControl()
        {
            var signUp = new SignUpUserControl();
            signUp.LoginRequested += (s, e) => LoadLoginControl();
            LoadUserControl(signUp);
        }

        private void LoadUserDashboardControl()
        {
            var dashboard = new DashboardUserControl();
            dashboard.LogOutRequested += (s, e) => LoadLoginControl();
            dashboard.AdminDashBoardRequested += (s, e) => LoadAdminDashboard();
            LoadUserControl(dashboard);
        }

        private void LoadAdminDashboard()
        {
            var dashboard = new DashboardAdminControl();
            dashboard.UserPanelRequested += (s, e) => LoadUserDashboardControl();
            LoadUserControl(dashboard);
        }

        private void LoadUserControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
    }
}
