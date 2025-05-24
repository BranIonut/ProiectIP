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
    public partial class DashboardUserControl : UserControl
    {
        public event EventHandler LogOutRequested;
        public event EventHandler AdminDashBoardRequested;

        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LogOutRequested?.Invoke(this, EventArgs.Empty);
           
        }

        private void adminDashButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
