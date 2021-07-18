namespace DoAn1
{
    partial class Search
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBoxGender = new System.Windows.Forms.ListBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(202, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(618, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // listBoxGender
            // 
            this.listBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGender.FormattingEnabled = true;
            this.listBoxGender.ItemHeight = 20;
            this.listBoxGender.Items.AddRange(new object[] {
            "ThieuNhi",
            "VanHoc",
            "KinhTe"});
            this.listBoxGender.Location = new System.Drawing.Point(659, 93);
            this.listBoxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxGender.Name = "listBoxGender";
            this.listBoxGender.Size = new System.Drawing.Size(204, 204);
            this.listBoxGender.TabIndex = 2;
            this.listBoxGender.Click += new System.EventHandler(this.listBoxGender_Click);
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.dataGridViewBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewBook.Location = new System.Drawing.Point(-3, 93);
            this.dataGridViewBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(658, 483);
            this.dataGridViewBook.TabIndex = 3;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 30;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.Location = new System.Drawing.Point(9, 23);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(54, 28);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseEnter += new System.EventHandler(this.BtnSearch_MouseEnter);
            this.BtnBack.MouseLeave += new System.EventHandler(this.BtnSearch_MouseLeave);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.White;
            this.BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearch.IconSize = 30;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(143, 26);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(54, 28);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.BtnSearch.MouseEnter += new System.EventHandler(this.BtnSearch_MouseEnter);
            this.BtnSearch.MouseLeave += new System.EventHandler(this.BtnSearch_MouseLeave);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(883, 587);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.listBoxGender);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listBoxGender;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}