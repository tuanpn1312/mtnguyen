namespace DoAn1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonReport = new FontAwesome.Sharp.IconButton();
            this.subpanelManage = new System.Windows.Forms.Panel();
            this.BtnManageVIP = new FontAwesome.Sharp.IconButton();
            this.BtnManageResources = new FontAwesome.Sharp.IconButton();
            this.ButtonManage = new FontAwesome.Sharp.IconButton();
            this.ButtonCart = new FontAwesome.Sharp.IconButton();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.ButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.BtnLogin = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.subpanelManage.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.panelMenu.Controls.Add(this.ButtonReport);
            this.panelMenu.Controls.Add(this.subpanelManage);
            this.panelMenu.Controls.Add(this.ButtonManage);
            this.panelMenu.Controls.Add(this.ButtonCart);
            this.panelMenu.Controls.Add(this.ButtonSearch);
            this.panelMenu.Controls.Add(this.ButtonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(223, 778);
            this.panelMenu.TabIndex = 1;
            // 
            // ButtonReport
            // 
            this.ButtonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonReport.FlatAppearance.BorderSize = 0;
            this.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReport.ForeColor = System.Drawing.Color.White;
            this.ButtonReport.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ButtonReport.IconColor = System.Drawing.Color.White;
            this.ButtonReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReport.Location = new System.Drawing.Point(0, 566);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(223, 78);
            this.ButtonReport.TabIndex = 7;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // subpanelManage
            // 
            this.subpanelManage.Controls.Add(this.BtnManageVIP);
            this.subpanelManage.Controls.Add(this.BtnManageResources);
            this.subpanelManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelManage.Location = new System.Drawing.Point(0, 426);
            this.subpanelManage.Name = "subpanelManage";
            this.subpanelManage.Size = new System.Drawing.Size(223, 140);
            this.subpanelManage.TabIndex = 6;
            // 
            // BtnManageVIP
            // 
            this.BtnManageVIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManageVIP.FlatAppearance.BorderSize = 0;
            this.BtnManageVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageVIP.ForeColor = System.Drawing.Color.White;
            this.BtnManageVIP.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.BtnManageVIP.IconColor = System.Drawing.Color.White;
            this.BtnManageVIP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnManageVIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageVIP.Location = new System.Drawing.Point(0, 78);
            this.BtnManageVIP.Name = "BtnManageVIP";
            this.BtnManageVIP.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnManageVIP.Size = new System.Drawing.Size(223, 78);
            this.BtnManageVIP.TabIndex = 8;
            this.BtnManageVIP.Text = "Manage Customer";
            this.BtnManageVIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageVIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnManageVIP.UseVisualStyleBackColor = true;
            this.BtnManageVIP.Click += new System.EventHandler(this.BtnManageVIP_Click);
            // 
            // BtnManageResources
            // 
            this.BtnManageResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManageResources.FlatAppearance.BorderSize = 0;
            this.BtnManageResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageResources.ForeColor = System.Drawing.Color.White;
            this.BtnManageResources.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnManageResources.IconColor = System.Drawing.Color.White;
            this.BtnManageResources.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnManageResources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageResources.Location = new System.Drawing.Point(0, 0);
            this.BtnManageResources.Name = "BtnManageResources";
            this.BtnManageResources.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnManageResources.Size = new System.Drawing.Size(223, 78);
            this.BtnManageResources.TabIndex = 7;
            this.BtnManageResources.Text = "Manage Resources";
            this.BtnManageResources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageResources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnManageResources.UseVisualStyleBackColor = true;
            this.BtnManageResources.Click += new System.EventHandler(this.BtnManageResources_Click);
            // 
            // ButtonManage
            // 
            this.ButtonManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonManage.FlatAppearance.BorderSize = 0;
            this.ButtonManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonManage.ForeColor = System.Drawing.Color.White;
            this.ButtonManage.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ButtonManage.IconColor = System.Drawing.Color.White;
            this.ButtonManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonManage.Location = new System.Drawing.Point(0, 348);
            this.ButtonManage.Name = "ButtonManage";
            this.ButtonManage.Size = new System.Drawing.Size(223, 78);
            this.ButtonManage.TabIndex = 5;
            this.ButtonManage.Text = "Manage";
            this.ButtonManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonManage.UseVisualStyleBackColor = true;
            this.ButtonManage.Click += new System.EventHandler(this.ButtonManage_Click);
            // 
            // ButtonCart
            // 
            this.ButtonCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCart.FlatAppearance.BorderSize = 0;
            this.ButtonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCart.ForeColor = System.Drawing.Color.White;
            this.ButtonCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ButtonCart.IconColor = System.Drawing.Color.White;
            this.ButtonCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCart.Location = new System.Drawing.Point(0, 270);
            this.ButtonCart.Name = "ButtonCart";
            this.ButtonCart.Size = new System.Drawing.Size(223, 78);
            this.ButtonCart.TabIndex = 4;
            this.ButtonCart.Text = "Bill";
            this.ButtonCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCart.UseVisualStyleBackColor = true;
            this.ButtonCart.Click += new System.EventHandler(this.ButtonCart_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ButtonSearch.IconColor = System.Drawing.Color.White;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new System.Drawing.Point(0, 192);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(223, 78);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDashboard
            // 
            this.ButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDashboard.FlatAppearance.BorderSize = 0;
            this.ButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDashboard.ForeColor = System.Drawing.Color.White;
            this.ButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.ButtonDashboard.IconColor = System.Drawing.Color.White;
            this.ButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDashboard.Location = new System.Drawing.Point(0, 114);
            this.ButtonDashboard.Name = "ButtonDashboard";
            this.ButtonDashboard.Size = new System.Drawing.Size(223, 78);
            this.ButtonDashboard.TabIndex = 2;
            this.ButtonDashboard.Text = "Dashboard";
            this.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDashboard.UseVisualStyleBackColor = true;
            this.ButtonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.BtnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 114);
            this.panelLogo.TabIndex = 2;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.BtnHome.BackgroundImage = global::DoAn1.Properties.Resources.atlas_1;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(223, 111);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.panelTitle.Controls.Add(this.BtnLogin);
            this.panelTitle.Controls.Add(this.iconButton1);
            this.panelTitle.Controls.Add(this.labelTitleChildForm);
            this.panelTitle.Controls.Add(this.IconCurrentChildFormIcon);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(223, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1177, 59);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtnLogin.IconColor = System.Drawing.Color.White;
            this.BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogin.IconSize = 25;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(952, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogin.Size = new System.Drawing.Size(132, 49);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 42;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(1119, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 41);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(46, 12);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(64, 25);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            this.labelTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconCurrentChildFormIcon
            // 
            this.IconCurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.IconCurrentChildFormIcon.ForeColor = System.Drawing.Color.BlueViolet;
            this.IconCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildFormIcon.IconColor = System.Drawing.Color.BlueViolet;
            this.IconCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildFormIcon.Location = new System.Drawing.Point(6, 12);
            this.IconCurrentChildFormIcon.Name = "IconCurrentChildFormIcon";
            this.IconCurrentChildFormIcon.Size = new System.Drawing.Size(34, 32);
            this.IconCurrentChildFormIcon.TabIndex = 0;
            this.IconCurrentChildFormIcon.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(223, 59);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1177, 719);
            this.panelChildForm.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 778);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "mainForm";
            this.panelMenu.ResumeLayout(false);
            this.subpanelManage.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ButtonManage;
        private FontAwesome.Sharp.IconButton ButtonCart;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private FontAwesome.Sharp.IconButton ButtonDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildFormIcon;
        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel subpanelManage;
        private FontAwesome.Sharp.IconButton BtnManageResources;
        private FontAwesome.Sharp.IconButton BtnLogin;
        private FontAwesome.Sharp.IconButton BtnManageVIP;
        private FontAwesome.Sharp.IconButton ButtonReport;
    }
}

