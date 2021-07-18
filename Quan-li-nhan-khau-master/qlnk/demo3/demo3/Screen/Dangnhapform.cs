using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3.Screen
{
    public partial class Dangnhapform : TempaltesForm
    {
        private List<string> user = new List<string>(); // tạo 1 xâu dữ liệu user kiểu string 
        private List<string> password = new List<string>(); // tạo 1 xâu dữ liệu password kiểu string
        public Dangnhapform()       // hàm khởi tạo form đăng nhập
        {
            InitializeComponent();
        }

        private void buttonthoat_Click(object sender, EventArgs e)  // hàm khi click vào button Thoát 
        {
            Application.Exit(); // lệnh thoát ra khỏi hoàn toàn chương trình
        }

        private void buttondangnhap_Click(object sender, EventArgs e)   //hàm khi click vào button Đăng nhập
        {
            {
                string a = "admin";     //tạo biến kiểu kí tự có giá trị là a="admin"
                string b = "admin";     //tạo biến kiểu kí tự có giá trị là b="admin"
                this.user.Add(a);       //thêm biến a vào xâu kí tự user của form đăng nhập
                this.password.Add(b);   //thêm biến b vào xâu kí tự password của form đăng nhập
                int check = 0;          // khởi tạo biến check=0
                foreach (string n in this.user)     //cho biến n chạy trong vòng foreach cho đến kí tự cuối cùng của user
                {
                    if (textBox1.Text == n)         // ô giá trị vừa nhập vào bằng n thì tiếp tục, ngược lại bỏ qua foreach dưới
                    {
                        foreach (string x in this.password) // cho biến x chạy trong vòng foreach cho đến kí tự cuối passoword
                        {
                            if (textBox2.Text == x)         //nếu giá trị vừa nhập ô password bằng x thì tiếp tục
                                                            //ngược lại thoát khỏi vòng foreach
                            {
                                Manhinhchinh demo = new Manhinhchinh(); //tạo biến demo bằng  form manhinhchinh
                                this.Hide();                    // lệnh giấu màn hình đăng nhập
                                demo.ShowDialog();              //hiện lên màn hình chính ,ngưng thực hiện những lệnh phía sau 
                                                                //cho đến khi màn hình chính tắt 
                                this.Show();
                                check = 1;                      //đổi lại biến check =1
                            }
                        }
                    }
                }
                if (check == 0) MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại !!!");
                //hiện lên dòng thông báo khi nhập sai tên đăng nhập hoặc mật khẩu hoặc không nhập
            }
        }

        private void Dangnhapform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                // câu lệnh truy xuất vào thư viện messagebox mà show ra câu thông báo có 2 button Ok và Cancel
                //nếu như có lệnh thoát khỏi chương trình thì sẽ hiện ra câu thông báo. nếu chọn chọn Ok thì DialogResult là Ok thì thoát khỏi chương trình
                e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
