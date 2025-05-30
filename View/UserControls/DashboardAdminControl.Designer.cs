namespace ChestionarAuto.UserControls
{
    partial class DashboardAdminControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.usersCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rolesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.quizzesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeUserButton = new System.Windows.Forms.Button();
            this.resetUserProgButton = new System.Windows.Forms.Button();
            this.removeQuizButton = new System.Windows.Forms.Button();
            this.createQuizButton = new System.Windows.Forms.Button();
            this.baskToUserPanelButton = new System.Windows.Forms.Button();
            this.changeRoleButton = new System.Windows.Forms.Button();
            this.helpAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard Admin";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usersCol,
            this.rolesCol});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 235);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // usersCol
            // 
            this.usersCol.Text = "Users";
            // 
            // rolesCol
            // 
            this.rolesCol.Text = "Role";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.quizzesColumn});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(395, 71);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(333, 235);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // quizzesColumn
            // 
            this.quizzesColumn.Text = "Quizzes";
            // 
            // removeUserButton
            // 
            this.removeUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserButton.Location = new System.Drawing.Point(46, 321);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(133, 35);
            this.removeUserButton.TabIndex = 3;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // resetUserProgButton
            // 
            this.resetUserProgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUserProgButton.Location = new System.Drawing.Point(215, 321);
            this.resetUserProgButton.Name = "resetUserProgButton";
            this.resetUserProgButton.Size = new System.Drawing.Size(132, 35);
            this.resetUserProgButton.TabIndex = 4;
            this.resetUserProgButton.Text = "Reset Progress";
            this.resetUserProgButton.UseVisualStyleBackColor = true;
            this.resetUserProgButton.Click += new System.EventHandler(this.resetUserProgButton_Click);
            // 
            // removeQuizButton
            // 
            this.removeQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeQuizButton.Location = new System.Drawing.Point(395, 321);
            this.removeQuizButton.Name = "removeQuizButton";
            this.removeQuizButton.Size = new System.Drawing.Size(119, 35);
            this.removeQuizButton.TabIndex = 5;
            this.removeQuizButton.Text = "Remove Quiz";
            this.removeQuizButton.UseVisualStyleBackColor = true;
            this.removeQuizButton.Click += new System.EventHandler(this.removeQuizButton_Click);
            // 
            // createQuizButton
            // 
            this.createQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuizButton.Location = new System.Drawing.Point(611, 321);
            this.createQuizButton.Name = "createQuizButton";
            this.createQuizButton.Size = new System.Drawing.Size(117, 35);
            this.createQuizButton.TabIndex = 6;
            this.createQuizButton.Text = "Create Quiz";
            this.createQuizButton.UseVisualStyleBackColor = true;
            this.createQuizButton.Click += new System.EventHandler(this.createQuizButton_Click);
            // 
            // baskToUserPanelButton
            // 
            this.baskToUserPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baskToUserPanelButton.Location = new System.Drawing.Point(611, 372);
            this.baskToUserPanelButton.Name = "baskToUserPanelButton";
            this.baskToUserPanelButton.Size = new System.Drawing.Size(117, 31);
            this.baskToUserPanelButton.TabIndex = 7;
            this.baskToUserPanelButton.Text = "User Panel";
            this.baskToUserPanelButton.UseVisualStyleBackColor = true;
            this.baskToUserPanelButton.Click += new System.EventHandler(this.baskToUserPanelButton_Click);
            // 
            // changeRoleButton
            // 
            this.changeRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeRoleButton.Location = new System.Drawing.Point(46, 372);
            this.changeRoleButton.Name = "changeRoleButton";
            this.changeRoleButton.Size = new System.Drawing.Size(133, 31);
            this.changeRoleButton.TabIndex = 9;
            this.changeRoleButton.Text = "Change Role";
            this.changeRoleButton.UseVisualStyleBackColor = true;
            this.changeRoleButton.Click += new System.EventHandler(this.changeRoleButton_Click_1);
            // 
            // helpAdminButton
            // 
            this.helpAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpAdminButton.Location = new System.Drawing.Point(215, 370);
            this.helpAdminButton.Name = "helpAdminButton";
            this.helpAdminButton.Size = new System.Drawing.Size(132, 35);
            this.helpAdminButton.TabIndex = 10;
            this.helpAdminButton.Text = "Help Admin";
            this.helpAdminButton.UseVisualStyleBackColor = true;
            this.helpAdminButton.Click += new System.EventHandler(this.helpAdminButton_Click);
            // 
            // DashboardAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpAdminButton);
            this.Controls.Add(this.changeRoleButton);
            this.Controls.Add(this.baskToUserPanelButton);
            this.Controls.Add(this.createQuizButton);
            this.Controls.Add(this.removeQuizButton);
            this.Controls.Add(this.resetUserProgButton);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "DashboardAdminControl";
            this.Size = new System.Drawing.Size(773, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button resetUserProgButton;
        private System.Windows.Forms.Button removeQuizButton;
        private System.Windows.Forms.Button createQuizButton;
        private System.Windows.Forms.Button baskToUserPanelButton;
        private System.Windows.Forms.ColumnHeader quizzesColumn;
        private System.Windows.Forms.ColumnHeader usersCol;
        private System.Windows.Forms.ColumnHeader rolesCol;
        private System.Windows.Forms.Button changeRoleButton;
        private System.Windows.Forms.Button helpAdminButton;
    }
}
