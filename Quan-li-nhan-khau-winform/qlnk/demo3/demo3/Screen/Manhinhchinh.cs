using demo3.Screen.Thủ_tục;
using demo3.Screen.Tra_cứu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo3.Screen.Đăng_ký;

namespace demo3.Screen
{
    public partial class Manhinhchinh : TempaltesForm
    {
        public Manhinhchinh()       //hàm tạo for màn hình chính
        {
            InitializeComponent();
        }
        //Khi click vào File->Thoát trong ToolStripMenuItem sẽ thoát khỏi chương trình
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // lệnh thoát khỏi chương trình
        }
        //hàm click vào Tra cứu -> Nhân khẩu
        private void nhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo 1 form f = form tra cứu nhân khẩu
            Tracuunhankhau f = new Tracuunhankhau();
            f.ShowDialog(); //chỉ thực hiện tiếp khi tắt form f
            this.Show();    //show form f
        }
        //hàm clcik vào Tra cứu-> hộ khẩu
        private void hộKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tracuuhokhau f = new Tracuuhokhau();
            f.ShowDialog();
            this.Show();

        }
        //Thủ tục -> diễn biến
        private void diễnBiếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dienbien f = new Dienbien();
            f.ShowDialog();
            this.Show();
        }
        //Thủ tục-> nhập tách khẩu
        private void nhậpTáchKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhap_tachkhau f = new Nhap_tachkhau();
            f.ShowDialog();
            this.Show();
        }
        //Thủ tục -> tạm trú tạm vắng
        private void tạmTrúvắngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tamtru_vang f = new Tamtru_vang();
            f.ShowDialog();
            this.Show();
        }
        //Thủ tục -> báo tử
        private void báoTửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baotu f = new Baotu();
            f.ShowDialog();
            this.Show();
        }
        //Đăng ký -> hộ khẩu
        private void hộKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hokhau f = new Hokhau();
            f.ShowDialog();
            this.Show();
        }
        //Event khi đóng click đóng màn hình chính -> thoát luôn chương trình
        private void Manhinhchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vềPhầnMềmQuảnLýNhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQLNK f = new AboutQLNK();
            f.ShowDialog();
            this.Show();
        }

        private void thêmMớiCôngDânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nhankhau11 f = new Nhankhau11();
            f.ShowDialog();
            this.Show();
        }
    }
}
