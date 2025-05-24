namespace ChestionarAuto.UserControls
{
    partial class DashboardUserControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adminDashButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(17, 26);
            this.welcomeBackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(199, 31);
            this.welcomeBackLabel.TabIndex = 0;
            this.welcomeBackLabel.Text = "Welcome back!";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(24, 81);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 406);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // adminDashButton
            // 
            this.adminDashButton.Location = new System.Drawing.Point(840, 351);
            this.adminDashButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminDashButton.Name = "adminDashButton";
            this.adminDashButton.Size = new System.Drawing.Size(137, 28);
            this.adminDashButton.TabIndex = 2;
            this.adminDashButton.Text = "Admin Panel";
            this.adminDashButton.UseVisualStyleBackColor = true;
            this.adminDashButton.Click += new System.EventHandler(this.adminDashButton_Click);
            // 
            // userSettingsButton
            // 
            this.userSettingsButton.Location = new System.Drawing.Point(840, 405);
            this.userSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(137, 28);
            this.userSettingsButton.TabIndex = 3;
            this.userSettingsButton.Text = "User Settings";
            this.userSettingsButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(840, 460);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(137, 28);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // startQuizButton
            // 
            this.startQuizButton.Location = new System.Drawing.Point(840, 33);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(137, 24);
            this.startQuizButton.TabIndex = 5;
            this.startQuizButton.Text = "Start Quiz";
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuizButton_Click);
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startQuizButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.userSettingsButton);
            this.Controls.Add(this.adminDashButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.welcomeBackLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(1031, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button adminDashButton;
        private System.Windows.Forms.Button userSettingsButton;
        private System.Windows.Forms.Button logOutButton;

        public void SetAdminDashBttnVisibility(bool ok)
        {
            adminDashButton.Visible = ok;
        }

        private System.Windows.Forms.Button startQuizButton;
    }
}
