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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.userQuizHistoryList = new System.Windows.Forms.ListView();
            this.adminDashButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(13, 21);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(178, 29);
            this.welcomeBackLabel.TabIndex = 0;
            this.welcomeBackLabel.Text = "Welcome back!";
            // 
            // userQuizHistoryList
            // 
            this.userQuizHistoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userQuizHistoryList.GridLines = true;
            this.userQuizHistoryList.HideSelection = false;
            this.userQuizHistoryList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.userQuizHistoryList.Location = new System.Drawing.Point(18, 66);
            this.userQuizHistoryList.Name = "userQuizHistoryList";
            this.userQuizHistoryList.Size = new System.Drawing.Size(567, 331);
            this.userQuizHistoryList.TabIndex = 1;
            this.userQuizHistoryList.UseCompatibleStateImageBehavior = false;
            this.userQuizHistoryList.View = System.Windows.Forms.View.List;
            // 
            // adminDashButton
            // 
            this.adminDashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDashButton.Location = new System.Drawing.Point(612, 244);
            this.adminDashButton.Name = "adminDashButton";
            this.adminDashButton.Size = new System.Drawing.Size(134, 39);
            this.adminDashButton.TabIndex = 2;
            this.adminDashButton.Text = "Admin Panel";
            this.adminDashButton.UseVisualStyleBackColor = true;
            this.adminDashButton.Click += new System.EventHandler(this.adminDashButton_Click);
            // 
            // userSettingsButton
            // 
            this.userSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSettingsButton.Location = new System.Drawing.Point(612, 301);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(134, 39);
            this.userSettingsButton.TabIndex = 3;
            this.userSettingsButton.Text = "User Settings";
            this.userSettingsButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(612, 361);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(134, 36);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // startQuizButton
            // 
            this.startQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startQuizButton.Location = new System.Drawing.Point(612, 66);
            this.startQuizButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(134, 41);
            this.startQuizButton.TabIndex = 5;
            this.startQuizButton.Text = "Start Quiz";
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuizButton_Click);
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startQuizButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.userSettingsButton);
            this.Controls.Add(this.adminDashButton);
            this.Controls.Add(this.userQuizHistoryList);
            this.Controls.Add(this.welcomeBackLabel);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(773, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.ListView userQuizHistoryList;
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
