using DoAn1.Connection;
using DoAn1.Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        my_db my_db = new my_db();
        SachController sachController = new SachController();
        PhieuNhap.PhieuNhap phieuNhap = new PhieuNhap.PhieuNhap();
        PhieuNhap.ChiTiet chiTiet = new PhieuNhap.ChiTiet();

        List<SachModel> bookList = new List<SachModel>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
       
                if (verif() && checkIDBook())
                {
                    string ID = txtMaSach.Text;
                    string name = txtTenSach.Text;
                    string tacGia = txtTacGia.Text;
                    string nxb = txtNXB.Text;
                    string moTa = txtMoTa.Text;
                    string danhMuc = txtTheLoai.Text;
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    int gia = Convert.ToInt32(txtGia.Text);

                    bookList.Add(new SachModel(ID, name, tacGia, nxb, moTa, danhMuc, quantity, gia));

                    fillGrid();
                    clearText();
                }
                else if (!verif())
                {
                    MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sách Này Đã Được Thêm Vào Danh Sách", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void fillGrid()
        {
            dataGridViewBook.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridViewBook.RowTemplate.Height = 80;

            dataGridViewBook.DataSource = null;

            dataGridViewBook.DataSource = bookList;

            setHeader();

            dataGridViewBook.AllowUserToAddRows = false;

            dataGridViewBook.ClearSelection();
        }

        private bool checkIDBook()
        {
            string ID = txtMaSach.Text;

            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].maSach == ID)
                {
                    return false;
                }
            }
            return true;
        }

        private bool verif()
        {
            if ((txtMaSach.Text.Trim() == "")
                   || (txtTenSach.Text.Trim() == "")
                   || (txtTacGia.Text.Trim() == "")
                   || (txtNXB.Text.Trim() == "")
                   || (txtMoTa.Text.Trim() == "")
                   || (txtTheLoai.Text.Trim() == "")
                                      || (txtGia.Text.Trim() == "")
                   || (txtQuantity.Text.Trim() == "")

                   || (txtNCC.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void clearText()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtMoTa.Text = "";
            txtTheLoai.Text = "";
            txtGia.Text = "";
            txtQuantity.Text = "";
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewBook.Rows[e.RowIndex];
                    Global.Global.setMaSach(row.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!sachController.checkIDBook(txtMaSach.Text))
                {
                    txtTenSach.Text = Global.Global.TenSach.ToString().Trim();
                    txtTacGia.Text = Global.Global.TacGia.ToString().Trim();
                    txtNXB.Text = Global.Global.NXB.ToString().Trim();
                    txtMoTa.Text = Global.Global.MoTa.ToString().Trim();
                    txtTheLoai.Text = Global.Global.DanhMuc.ToString().Trim();
                    txtGia.Text = Global.Global.Gia.ToString().Trim();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            phieuNhap.layIDPhieuNhap();
            txtPhieu.Text = Global.Global.maPhieuNhap.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (SachModel sach in bookList)
                {
                    if (string.Equals(sach.maSach, Global.Global.MaSach))
                    {
                        bookList.Remove(sach);
                        fillGrid();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void setHeader()
        {
            dataGridViewBook.Columns["maSach"].HeaderText = "Mã Sách";

            dataGridViewBook.Columns["tenSach"].HeaderText = "Tên Sách";

            dataGridViewBook.Columns["tacGia"].HeaderText = "Tác Giả";

            dataGridViewBook.Columns["nXB"].HeaderText = "NXB";

            dataGridViewBook.Columns["moTa"].HeaderText = "Mô Tả";

            dataGridViewBook.Columns["danhMuc"].HeaderText = "Danh Mục";

            dataGridViewBook.Columns["soLuongTon"].HeaderText = "Số Lượng Nhập";

            dataGridViewBook.Columns["gia"].HeaderText = "Giá";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtPhieu.Text);
            string ncc = txtNCC.Text;
            DateTime date = DateTime.Now;
            int tong = 0;
            phieuNhap.insertPhieuNhap(ID, date, ncc, tong);

            foreach (SachModel sach in bookList)
            {
                if (sachController.checkIDBook(sach.maSach))
                {
                    string id = sach.maSach;
                    string name = sach.tenSach;
                    string tacGia = sach.tacGia;
                    string nxb = sach.nXB;
                    string moTa = sach.moTa;
                    string danhMuc = sach.danhMuc;
                    int Quantity = sach.soLuongTon;
                    tong += sach.soLuongTon;
                    int gia = sach.gia;

                    sachController.insertBook(id, name, tacGia, nxb, moTa, danhMuc, Quantity, gia);
                    chiTiet.insertChiTiet(ID, sach.maSach, sach.soLuongTon);
                }
                else
                {
                    int quantityUpdate = Global.Global.SoLuong + sach.soLuongTon;
                    sachController.updateQuantity(sach.maSach, quantityUpdate);
                    chiTiet.insertChiTiet(ID, sach.maSach, sach.soLuongTon);
                    tong += sach.soLuongTon;
                }
            }
            MessageBox.Show("Nhập Hàng Vào Kho Thành Công", "Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            phieuNhap.updateTongSoLuong(ID, tong);
            bookList.Clear();
            fillGrid();
            clearText();
            txtNCC.Text = "";
            phieuNhap.layIDPhieuNhap();
            txtPhieu.Text = Global.Global.maPhieuNhap.ToString();

        }
    }
}
