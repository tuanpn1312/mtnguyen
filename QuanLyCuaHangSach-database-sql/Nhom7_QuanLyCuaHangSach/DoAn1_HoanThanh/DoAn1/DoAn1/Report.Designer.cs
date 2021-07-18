namespace DoAn1
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReport = new FontAwesome.Sharp.IconButton();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
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
            this.BtnBack.Location = new System.Drawing.Point(12, 31);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(72, 34);
            this.BtnBack.TabIndex = 137;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Date1
            // 
            this.Date1.Checked = false;
            this.Date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date1.Location = new System.Drawing.Point(147, 86);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(340, 30);
            this.Date1.TabIndex = 139;
            // 
            // Date2
            // 
            this.Date2.Checked = false;
            this.Date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date2.Location = new System.Drawing.Point(527, 86);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(345, 30);
            this.Date2.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "to";
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReport.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.BtnReport.IconColor = System.Drawing.Color.White;
            this.BtnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReport.Location = new System.Drawing.Point(1064, 51);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(101, 65);
            this.BtnReport.TabIndex = 142;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(1153, 573);
            this.dataGridViewReport.TabIndex = 138;
            this.dataGridViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReport_CellContentClick);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1177, 719);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.BtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnReport;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewReport;
    }
}