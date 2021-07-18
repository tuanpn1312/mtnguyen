using DoAn2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choose,choose1,choose2,choose3,choose4;
            List<LaiXe> dslaixe = new List<LaiXe>();
            do
            {
                Console.Clear();
                Menuchinh();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            do
                            {
                                Console.Clear();
                                Menunhanvien();
                                choose1 = int.Parse(Console.ReadLine());
                                NhanVien nv = new LaiXe();
                                switch (choose1)
                                {
                                    case 1:
                                        {
                                            do
                                            {
                                                nv.DocfileNv("dslaixe.txt");
                                                Console.Clear();
                                                Menunhanvienlaixe();
                                                choose2 = int.Parse(Console.ReadLine());
                                                switch (choose2)
                                                {
                                                    case 1:
                                                        {
                                                            nv.Them();
                                                            nv.GhifileNv("dslaixe.txt");
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon xoa: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            nv.Xoa(temp);
                                                            nv.GhifileNv("dslaixe.txt");
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon sua: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            nv.Sua(temp);
                                                            nv.GhifileNv("dslaixe.txt");
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            do
                                                            {

                                                                Console.Clear();
                                                                TKnhanvienlaixe();
                                                                choose1 = int.Parse(Console.ReadLine());
                                                                switch (choose1)
                                                                {
                                                                    case 1:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.search();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 2:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.luongmax();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 3:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.luongmin();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 4:
                                                                        {
                                                                            nv.sort();
                                                                            break;
                                                                        }
                                                                    default:
                                                                        {
                                                                            
                                                                            break;
                                                                        }
                                                                }
                                                            } while (choose1 != 5);
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            
                                                            break;
                                                        }
                                                }
                                            } while (choose2 != 5);
                                            break;
                                        }
                                    case 2:
                                        {
                                            nv = new BanVe();
                                            do
                                            {
                                                nv.DocfileNv("dsbanve.txt");
                                                Console.Clear();
                                                Menunhanvienbanve();
                                                choose2 = int.Parse(Console.ReadLine());
                                                switch (choose2)
                                                {
                                                    case 1:
                                                        {
                                                            nv.Them();
                                                            nv.GhifileNv("dsbanve.txt");
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon xoa: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            nv.Xoa(temp);
                                                            nv.GhifileNv("dsbanve.txt");
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon sua: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            nv.Sua(temp);
                                                            nv.GhifileNv("dsbanve.txt");
                                                            break;
                                                        }
                                                    case 4:
                                                        {

                                                            do
                                                            {

                                                                Console.Clear();
                                                                TKnhanvienbanve();
                                                                choose2 = int.Parse(Console.ReadLine());
                                                                switch (choose2)
                                                                {
                                                                    case 1:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.search();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 2:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.luongmax();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 3:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            nv.luongmin();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 4:
                                                                        {
                                                                            nv.sort();
                                                                            break;
                                                                        }
                                                                    default:
                                                                        {
                                                                            
                                                                            break;
                                                                        }
                                                                }
                                                                
                                                            } while (choose2 != 5);
                                                            break;
                                                        }


                                                    default:
                                                        {
                                                            
                                                            break;
                                                        }
                                                }
                                            } while (choose2 != 5);
                                            break;
                                        }
                                    default:
                                        {
                                            
                                            break;
                                        }
                                }
                            } while (choose1 != 3);
                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                Console.Clear();
                                Menuqlve();
                                choose3 = int.Parse(Console.ReadLine());
                                Vexe vx = new Vexe();
                                vx.DocfileTxt("dsvx.txt");
                                switch (choose3)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            vx.Them();
                                            vx.GhifileTxt("dsvx.txt");
                                            break;
                                        }
                                    case 2:
                                        {
                                            int temp;
                                            Console.Write("Nhap vi tri phan tu ban muon xoa: ");
                                            temp = int.Parse(Console.ReadLine());
                                            vx.Xoa(temp);
                                            vx.GhifileTxt("dsvx.txt");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            string enter;
                                            vx.Searchtheomachuyen();
                                            Console.Write("Nhấn enter để tiếp tục  ");
                                            enter = Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            string enter;
                                            vx.Searchnoiden();
                                            Console.Write("Nhấn enter để tiếp tục  ");
                                            enter = Console.ReadLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            vx.Sort();
                                            break;
                                        }
                                    default:
                                        {
                                            
                                            break;
                                        }
                                }
                            } while (choose3 != 6);
                            break;
                         }
                    case 3:
                        {
                            do
                            {
                                Console.Clear();
                                quanlichuyen();
                                choose3 = int.Parse(Console.ReadLine());
                                Ngoaithanh chuyen = new Ngoaithanh();
                                switch (choose3)
                                {
                                    case 1:
                                        {
                                            do
                                            {
                                                //Ngoaithanh chuyen = new Ngoaithanh();
                                                chuyen.DocfileTxt("dsngoaithanh.txt");
                                                Console.Clear();
                                                quanlingoaithanh();
                                                choose4 = int.Parse(Console.ReadLine());
                                                switch (choose4)
                                                {
                                                    case 1:
                                                        {
                                                            chuyen.Them();
                                                            chuyen.GhifileTxt("dsngoaithanh.txt");
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon xoa: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            chuyen.Xoa(temp);
                                                            chuyen.GhifileTxt("dsngoaithanh.txt");
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon sua: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            chuyen.Sua(temp);
                                                            chuyen.GhifileTxt("dsngoaithanh.txt");
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            do
                                                            {

                                                                Console.Clear();
                                                                TKngoaithanh();
                                                                choose4 = int.Parse(Console.ReadLine());
                                                                switch (choose4)
                                                                {
                                                                    case 1:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen.Search();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 2:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen.chuyenmax();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 3:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen.chuyenmin();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 4:
                                                                        {
                                                                            chuyen.Sort();
                                                                            break;
                                                                        }
                                                                    default:
                                                                        {
                                                                            
                                                                            break;
                                                                        }
                                                                }
                                                            } while (choose4 != 5);
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            
                                                            break;
                                                        }
                                                }
                                            } while (choose4 != 5);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Noithanh chuyen1 = new Noithanh();
                                            do
                                            {
                                                chuyen1.DocfileTxt("dsnoithanh.txt");
                                                Console.Clear();
                                                quanlinoithanh();
                                                choose4 = int.Parse(Console.ReadLine());
                                                switch (choose4)
                                                {
                                                    case 1:
                                                        {
                                                            chuyen1.Them();
                                                            chuyen1.GhifileTxt("dsnoithanh.txt");
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon xoa: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            chuyen1.Xoa(temp);
                                                            chuyen1.GhifileTxt("dsnoithanh.txt");
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            int temp;
                                                            Console.Write("Nhap vi tri phan tu ban muon sua: ");
                                                            temp = int.Parse(Console.ReadLine());
                                                            chuyen1.Sua(temp);
                                                            chuyen1.GhifileTxt("dsnoithanh.txt");
                                                            break;
                                                        }
                                                    case 4:
                                                        {

                                                            do
                                                            {

                                                                Console.Clear();
                                                                TKnoithanh();
                                                                choose4 = int.Parse(Console.ReadLine());
                                                                switch (choose4)
                                                                {
                                                                    case 1:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen1.Search();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 2:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen1.chuyenmax();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 3:
                                                                        {
                                                                            Console.Clear();
                                                                            string enter;
                                                                            chuyen1.chuyenmin();
                                                                            Console.Write("Nhấn enter để tiếp tục ....");
                                                                            enter = Console.ReadLine();
                                                                            break;
                                                                        }
                                                                    case 4:
                                                                        {
                                                                            chuyen1.Sort();
                                                                            break;
                                                                        }
                                                                    default:
                                                                        {
                                                                            
                                                                            break;
                                                                        }
                                                                }
                                                            } while (choose4 != 5);
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            
                                                            break;
                                                        }
                                                }
                                            } while (choose4 != 5);
                                            break;
                                        }
                                    default:
                                        {
                                            
                                            break;
                                        }
                                }
                            } while (choose3 != 3);
                            break;
                        }
                    default:
                        {
                            
                            break;
                        }
                }
            } while (choose != 0);  
        }
        static void Menuchinh()
        {
            Console.WriteLine("                                     ---------------CHUONG TRINH QUAN LY NHA XE BAN VE---------------\n");
            Console.WriteLine("                                                         1.Quản lý nhân viên\n");
            Console.WriteLine("                                                         2.Quan ly xe\n");
            Console.WriteLine("                                                         3.Quản lý chuyến đi\n");
            Console.Write("                                                         Nhập sự lựa chọn của bạn: ");
        }
        static void Menunhanvien()
        {
            Console.WriteLine("     --------------------------------------------------------QUẢN LÍ NHÂN VIÊN--------------------------------------------------------------------------------\n");
            Console.WriteLine("                                                         1.Nhân viên lái xe\n");
            Console.WriteLine("                                                         2.Nhân viên bán vé\n");
            Console.WriteLine("                                                         3.Quay về màn hình chính\n");
            Console.Write("                                                         Nhập sự lựa chọn của bạn: ");
        }
        static void Menunhanvienlaixe()
        {
            LaiXe lx = new LaiXe();
            Console.WriteLine("     ----------------------------------------------------QUẢN LÍ NHÂN VIÊN LÁI XE ----------------------------------------------------\n");
            lx.DocfileNv("dslaixe.txt");
            lx.Xuat();
            Console.WriteLine("                                       1.Thêm nhân viên                           3.Cập nhập nhân viên\n");
            Console.WriteLine("                                       2.Xóa nhân viên                            4.Thống kê nhân viên\n");
            Console.WriteLine("                                                               5.Thoát\n");
            Console.Write("                                                             Sự lựa chọn của bạn: ");
        }
        static void Menunhanvienbanve()
        {
            BanVe lx = new BanVe();
            Console.WriteLine("     ----------------------------------------------------QUẢN LÍ NHÂN VIÊN BÁN VÉ--------------------------------------------------  -\n");
            lx.DocfileNv("dsbanve.txt");
            lx.Xuat();
            Console.WriteLine("                                       1.Thêm nhân viên                          3.Cập nhập nhân viên\n");
            Console.WriteLine("                                       2.Xóa nhân viên                           4.Thống kê nhân viên\n");
            Console.WriteLine("                                                               5.Thoát\n");
            Console.Write("                                                             Sự chọn lựa của bạn: ");
        }
        static void TKnhanvienbanve()
        {
            BanVe lx = new BanVe();
            Console.WriteLine("     --------------------------------------------------------THỐNG KÊ BÁN VÉ----------------------------------------------------------\n");
            lx.DocfileNv("dsbanve.txt");
            lx.Xuat();
            Console.WriteLine("                              1.Tìm kiếm nhân viên bán vé                         4.Sắp xếp tăng dần theo lương\n");
            Console.WriteLine("                              2.Nhân viên có lương max                            5.Thoát\n");
            Console.WriteLine("                              3.Nhân viên có lương min                            \n");
            Console.Write("                                                              Sự lựa chọn của bạn: ");
        }
        static void TKnhanvienlaixe()
        {
            LaiXe lx = new LaiXe();
            Console.WriteLine("     ------------------------------------------------------- THỐNG KÊ LÁI XE----------------------------------------------------------\n");
            lx.DocfileNv("dslaixe.txt");
            lx.Xuat();
            Console.WriteLine("                              1.Tìm kiếm nhân viên                                4.Sắp xếp tăng dần theo lương\n");
            Console.WriteLine("                              2.Nhân viên có lương max                            5.Thoát\n");
            Console.WriteLine("                              3.Nhân viên có lương min                            \n");
            Console.Write("                                                             Sự lưa chọn của bạn: ");
        }
        static void quanlichuyen()
        {
        
            Console.WriteLine("     ---------------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN XE----------------------------------------------------------------------------------\n");
            Console.WriteLine("                                                                                                   1.Ngoại thành                            \n");
            Console.WriteLine("                                                                                                   2.Nội thành                            \n");
            Console.WriteLine("                                                                                                   3.Thoát\n");
            Console.Write("                                                                                                 Sự lưa chọn của bạn: ");
        }
        static void quanlingoaithanh()
        {
            Ngoaithanh lx = new Ngoaithanh();
            Console.WriteLine("     -----------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN NGOẠI THÀNH-----------------------------------------------------------------------------\n");
            lx.DocfileTxt("dsngoaithanh.txt");
            lx.Xuat();
            Console.WriteLine("                                                                               1.Thêm chuyến                           3.Cập nhập chuyến\n");
            Console.WriteLine("                                                                               2.Xóa chuyến                            4.Thống kê chuyến\n");
            Console.WriteLine("                                                                                                     5.Thoát\n");
            Console.Write("                                                                                                  Sự lưa chọn của bạn: ");
        }
        static void quanlinoithanh()
        {
            Noithanh lx = new Noithanh();
            Console.WriteLine("     ----------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN NỘI THÀNH--------------------------------------------------------------------------------\n");
            lx.DocfileTxt("dsnoithanh.txt");
            lx.Xuat();
            Console.WriteLine("                                                                             1.Thêm chuyến                           3.Cập nhập chuyến\n");
            Console.WriteLine("                                                                             2.Xóa chuyến                            4.Thống kê chuyến\n");
            Console.WriteLine("                                                                                                  5.Thoát\n");
            Console.Write("                                                                                                 Sự lưa chọn của bạn: ");
        }
        static void TKngoaithanh()
        {
            Ngoaithanh lx = new Ngoaithanh();
            Console.WriteLine("     ----------------------------------------------------------------------------------------THỐNG KÊ NGOẠI THÀNH------------------------------------------------------------------------------------\n");
            lx.DocfileTxt("dsngoaithanh.txt");
            lx.Xuat();
            Console.WriteLine("                                                                   1.Tìm kiếm chuyến                                   4.Sắp xếp tăng dần theo doanhthu\n");
            Console.WriteLine("                                                                   2.Chuyến có doanh thu max                           5.Thoát\n");
            Console.WriteLine("                                                                   3.Chuyến có doanh thu min                           \n");
            Console.Write("                                                                                                 Sự lựa chọn của bạn: ");
        }
        static void TKnoithanh()
        {
            Noithanh lx = new Noithanh();
            Console.WriteLine("     ----------------------------------------------------------------------------------------THỐNG KÊ NỘI THÀNH-------------------------------------------------------------------------------------\n");
            lx.DocfileTxt("dsnoithanh.txt");
            lx.Xuat();
            Console.WriteLine("                                                                 1.Tìm kiếm chuyến                                   4.Sắp xếp tăng dần theo doanhthu\n");
            Console.WriteLine("                                                                 2.Chuyến có doanh thu max                           5.Thoát\n");
            Console.WriteLine("                                                                 3.Chuyến có doanh thu min                           \n");
            Console.Write("                                                                                             Sự lựa chọn của bạn: ");
        }
        static void Menuqlve()
        {
            Vexe vx = new Vexe();
            vx.DocfileTxt("dsvx.txt");
            vx.Xuat();
            Console.WriteLine("                                                                 1.Đăng ký vé                                   3.Tìm kiếm vé đã mua theo chuyến\n");
            Console.WriteLine("                                                                 2.Xóa vé                                       4.Tìm kiếm vé đã mua theo nơi đến \n");
            Console.WriteLine("                                                                 5.Sắp xếp theo thứ tự tăng dần mã chuyến       6.Thoát \n");
            Console.Write("                                                                                          Sự lựa chọn của bạn: ");
        }
    }

}
