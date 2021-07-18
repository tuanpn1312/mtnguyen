namespace demo3.Screen
{
    partial class Dangnhapform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhapform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.labelDangnhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonthoat);
            this.panel1.Controls.Add(this.buttondangnhap);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelmatkhau);
            this.panel1.Controls.Add(this.labelDangnhap);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 533);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright @ TuanTuITFHQ";
            // 
            // buttonthoat
            // 
            this.buttonthoat.Location = new System.Drawing.Point(631, 368);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(104, 31);
            this.buttonthoat.TabIndex = 5;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.Location = new System.Drawing.Point(467, 368);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(104, 31);
            this.buttondangnhap.TabIndex = 4;
            this.buttondangnhap.Text = "Đăng nhập";
            this.buttondangnhap.UseVisualStyleBackColor = true;
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(384, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(351, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 22);
            this.textBox1.TabIndex = 2;
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.labelmatkhau.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhau.Location = new System.Drawing.Point(158, 307);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(101, 23);
            this.labelmatkhau.TabIndex = 1;
            this.labelmatkhau.Text = "Mật khẩu :";
            // 
            // labelDangnhap
            // 
            this.labelDangnhap.AutoSize = true;
            this.labelDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.labelDangnhap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangnhap.Location = new System.Drawing.Point(158, 251);
            this.labelDangnhap.Name = "labelDangnhap";
            this.labelDangnhap.Size = new System.Drawing.Size(153, 23);
            this.labelDangnhap.TabIndex = 0;
            this.labelDangnhap.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN KHẨU";
            // 
            // Dangnhapform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(943, 531);
            this.Controls.Add(this.panel1);
            this.Name = "Dangnhapform";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dangnhapform_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelmatkhau;
        private System.Windows.Forms.Label labelDangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}