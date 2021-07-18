using DoAn1.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Login : Form
    {
        my_db mydb = new my_db();

        public Login()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.Red;
            iconButton2.IconColor = Color.White;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.Transparent;
            iconButton2.IconColor = Color.Red;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.White;
            btnConfirm.ForeColor = Color.FromArgb(0, 163, 254);
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(0, 163, 254);
            btnConfirm.ForeColor = Color.White;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT dbo.Login_Check(@User, @Pass)", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtPass.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    int maChucVu = Convert.ToInt32(table.Rows[0][0].ToString());
                    if (maChucVu != -1)
                    {
                        Global.Global.setMaChuc(maChucVu);
                        MainForm.setIsLogin(true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Dữ Liệu", "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
