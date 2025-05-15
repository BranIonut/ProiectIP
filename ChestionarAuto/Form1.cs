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
    public partial class Form1 : Form
    {
        private Panel containerPanel;
        private Button btnSwitch;
        private bool isPanel1Visible = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void goToSignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Visible = false;
            signUpPanel.Visible = false;
            signUpPanel.BringToFront();
            signUpPanel.Visible = true;

        }

        private void goToLogInPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Visible = false;
            signUpPanel.Visible = false;
            loginPanel.BringToFront();
            loginPanel.Visible = true;
            
        }
    }
}
