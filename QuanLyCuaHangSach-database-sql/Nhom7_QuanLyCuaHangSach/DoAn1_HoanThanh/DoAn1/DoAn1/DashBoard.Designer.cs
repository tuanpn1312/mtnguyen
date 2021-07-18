namespace DoAn1
{
    partial class DashBoard
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
            this.labelMoment = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelMoment
            // 
            this.labelMoment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMoment.BackColor = System.Drawing.Color.White;
            this.labelMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMoment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMoment.Location = new System.Drawing.Point(541, 655);
            this.labelMoment.Name = "labelMoment";
            this.labelMoment.Size = new System.Drawing.Size(214, 44);
            this.labelMoment.TabIndex = 6;
            this.labelMoment.Text = "Moment";
            this.labelMoment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Time.Location = new System.Drawing.Point(994, 655);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(171, 44);
            this.Time.TabIndex = 5;
            this.Time.Text = "time";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.BackColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Date.Location = new System.Drawing.Point(772, 655);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(216, 44);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMess
            // 
            this.txtMess.BackColor = System.Drawing.Color.White;
            this.txtMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMess.Location = new System.Drawing.Point(12, 62);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(1153, 570);
            this.txtMess.TabIndex = 70;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.BtnBack.Location = new System.Drawing.Point(59, 22);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(72, 34);
            this.BtnBack.TabIndex = 69;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1177, 722);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.labelMoment);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoment;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Timer timer1;
    }
}