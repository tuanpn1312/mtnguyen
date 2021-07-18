using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    public class BanVe: NhanVien
    {
        private int sSocalamviec;
        List<BanVe> ldsbanve = new List<BanVe>();
        //
        public int Socalamviec
        {
            get { return this.sSocalamviec; }
            set { this.sSocalamviec = value; }
        }
        public List<BanVe> dsbanve
        {
            get { return this.ldsbanve; }
            set { this.ldsbanve = value; }
        }
        //
        public BanVe() : base()
        {

        }
       //
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ca lam viec: ");
            this.sSocalamviec= int.Parse(Console.ReadLine());
            this.iLuong = tinhluong();
        }
        //
        public override void Xuat()
        {
            Console.WriteLine("     -----------------------------------------------------DANH SÁCH NHÂN VIÊN BÁN VÉ---------------------------------------------------");
            Console.WriteLine("     _________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -15} |", "Số ca làm việc"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsbanve.Count; i++)
            {
                Console.Write(string.Format("{0, 8} |", i+1));
                Console.Write(string.Format(" {0, -12} |", dsbanve[i].iManv));
                Console.Write(string.Format(" {0, -19} |", dsbanve[i].sHoten));
                Console.Write(string.Format(" {0, -15} |", dsbanve[i].sCMND));
                Console.Write(string.Format(" {0, -12} |", dsbanve[i].iNamsinh));
                Console.Write(string.Format(" {0, -12} |", dsbanve[i].dNgaycong));
                Console.Write(string.Format(" {0, -15} |", dsbanve[i].sSocalamviec));
                Console.Write(string.Format(" {0, -19} |", dsbanve[i].iLuongcb));
                Console.WriteLine(string.Format(" {0, -20} |", dsbanve[i].iLuong + " $"));
                Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        
        public override void GhifileNv(String filename)
        {
            FileStream fnv = new FileStream(filename, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            for (int i = 0; i < dsbanve.Count; i++)
            {
                swrite.WriteLine(dsbanve[i].Manv);
                swrite.WriteLine(dsbanve[i].Hoten);
                swrite.WriteLine(dsbanve[i].CMND);
                swrite.WriteLine(dsbanve[i].Namsinh);
                swrite.WriteLine(dsbanve[i].Ngaycong);
                swrite.WriteLine(dsbanve[i].Luongcb);
                swrite.WriteLine(dsbanve[i].sSocalamviec);
                swrite.WriteLine(dsbanve[i].Luong);
            }
            swrite.Flush();
            dsbanve = new List<BanVe>();
            fnv.Close();
        }
        public override void DocfileNv(String filename)
        {
            FileStream fp = new FileStream(filename, FileMode.Open);
            StreamReader rd = new StreamReader(fp, Encoding.UTF8);
            int dem = 0;
            while (rd.ReadLine() != null)
            {
                dem++;
            }
            int size = dem / 8;
            rd.Close();
            fp.Close();
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader rd1 = new StreamReader(fp1, Encoding.UTF8);
            for (int i = 0; i < size; i++)
            {
                BanVe lx = new BanVe();
                lx.Manv = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Hoten = rd1.ReadLine();
                lx.CMND = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Namsinh = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Ngaycong = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Luongcb = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Socalamviec = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Luong = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                dsbanve.Add(lx);
            }
            fp1.Close();
            rd1.Close();
        }
        public override void Them()
        {
            int n;
            Console.Write("So nhan vien ban ve muon nhap: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BanVe bv = new BanVe();
                bv.Nhap();
                dsbanve.Add(bv);
            }
        }
        public override void Xoa(int temp)
        {
            List<BanVe> tam = dsbanve;
            dsbanve = new List<BanVe>();
            temp = temp - 1;
            // Neu temp <= 0 => Xoa dau
            if (temp < 0)
            {
                temp = 0;
            }
            // Neu temp >= n => Xoa cuoi
            else if (temp >= tam.Count)
            {
                temp = tam.Count - 1;
            }
            // Dich chuyen mang
            for (int i = 0; i < tam.Count; i++)
            {
                BanVe TT = new BanVe();
                if (i != temp)
                {
                    TT = tam[i];
                    dsbanve.Add(TT);
                }
            }
        }
        public override void Sua(int temp)
        {
            temp = temp - 1;
            BanVe bvmoi = new BanVe();
            bvmoi.Nhap();
            dsbanve[temp] = bvmoi;
        }
        public override int tinhluong()
        {
            return this.iLuong = this.iLuongcb + this.sSocalamviec * this.dNgaycong * 30000;
        }
        public static bool operator >(BanVe a, BanVe b)
        {
            if (a.iLuong < b.iLuong) return false;
            return true;
        }
        public static bool operator <(BanVe a, BanVe b)
        {
            if (a.iLuong > b.iLuong) return false;
            return true;
        }
        public  void sosanh2()
        {
            int dem = 0;
            int vt1 = 0;
            int vt2 = 0;
            Console.WriteLine("Nhập nhân viên thứ nhất cần tìm: ");
            int NV1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập nhân viên thứ hai cần tìm: ");
            int NV2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < dsbanve.Count; i++)
            {
                if (dsbanve[i].Manv == NV1)
                {
                    dem++;
                    vt1 = i;
                }
                if (dsbanve[i].Manv == NV2)
                {
                    dem++;
                    vt2 = i;
                }
            }
            if (dem <= 1) Console.WriteLine("---> không tìm thấy <--- ");
            if (dem > 1)
            {
                if (dsbanve[vt1] > dsbanve[vt2]) Console.WriteLine("Chuyến có mã " + dsbanve[vt1].Hoten + " lớn hơn " + dsbanve[vt2].Hoten);
                if (dsbanve[vt1] < dsbanve[vt2]) Console.WriteLine("Chuyến có mã " + dsbanve[vt1].Hoten + " bé hơn " + dsbanve[vt2].Hoten);
                if (dsbanve[vt1] == dsbanve[vt2]) Console.WriteLine("Chuyến có mã " + dsbanve[vt1].Hoten + " bằng " + dsbanve[vt2].Hoten);
                if (dsbanve[vt1] != dsbanve[vt2]) Console.WriteLine("Chuyến có mã " + dsbanve[vt1].Hoten + " khác " + dsbanve[vt2].Hoten);

            }
        }
        public override void sort()    //sắp xếp tăng dần
        {
            
            BanVe t;
            for (int i = 0; i < dsbanve.Count - 1; i++)
            {
                for (int j = i + 1; j < dsbanve.Count; j++)
                {
                    if (dsbanve[i] > dsbanve[j])
                    {
                        t = dsbanve[i];
                        dsbanve[i] = dsbanve[j];
                        dsbanve[j] = t;
                    }
                }
            }
            GhifileNv("dsbanve.txt");
            dsbanve = new List<BanVe>();
        }
        public override void search()  //tìm kiếm theo tên
        {
            int dem1 = 0;
                Console.WriteLine("Nhập tên Nhân Viên bán vé cần tìm: ");
                string NV = Console.ReadLine();
            Console.WriteLine("     -----------------------------------------------------DANH SACH NHAN VIEN BAN VE---------------------------------------------------");
            Console.WriteLine("     _________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -15} |", "Số ca làm việc"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsbanve.Count; i++)
            {
                if (dsbanve[i].sHoten == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0, 8} |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dsbanve[i].iManv));
                    Console.Write(string.Format(" {0, -19} |", dsbanve[i].sHoten));
                    Console.Write(string.Format(" {0, -15} |", dsbanve[i].sCMND));
                    Console.Write(string.Format(" {0, -12} |", dsbanve[i].iNamsinh));
                    Console.Write(string.Format(" {0, -12} |", dsbanve[i].dNgaycong));
                    Console.Write(string.Format(" {0, -15} |", dsbanve[i].sSocalamviec));
                    Console.Write(string.Format(" {0, -19} |", dsbanve[i].iLuongcb));
                    Console.WriteLine(string.Format(" {0, -20} |", dsbanve[i].iLuong + " $"));
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            } 
                if (dem1 == 0) Console.WriteLine("---> không tìm thấy <--- ");
        }
        public  override void luongmax()
        {
            Console.WriteLine("     _______________________________________________________________NHÂN VIÊN CÓ LƯƠNG CAO NHẤT_______________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -15} |", "Số ca làm việc"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
            double maxve = 0;
            int vt = 0;
            for (int i = 0; i < dsbanve.Count; i++)
            {
                if (dsbanve[i].tinhluong() > maxve)
                {
                    maxve = dsbanve[i].tinhluong();
                    vt = i;
                }
            }
            Console.Write(string.Format("{0, 8} |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].iManv));
            Console.Write(string.Format(" {0, -19} |", dsbanve[vt].sHoten));
            Console.Write(string.Format(" {0, -15} |", dsbanve[vt].sCMND));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].iNamsinh));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].dNgaycong));
            Console.Write(string.Format(" {0, -15} |", dsbanve[vt].sSocalamviec));
            Console.Write(string.Format(" {0, -19} |", dsbanve[vt].iLuongcb));
            Console.WriteLine(string.Format(" {0, -20} |", dsbanve[vt].iLuong + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        // tìm nhân viên bán vé lương thấp nhất
        public override void luongmin()
        { 
            Console.WriteLine("     _______________________________________________________________NHÂN VIÊN CÓ LƯƠNG THẤP NHẤT______________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -15} |", "Số ca làm việc"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
            double maxve = dsbanve[0].tinhluong();
            int vt = 0;
            for (int i = 0; i < dsbanve.Count; i++)
            {
                if (dsbanve[i].tinhluong() < maxve)
                {
                    maxve = dsbanve[i].tinhluong();
                    vt = i;
                }
            }
            Console.Write(string.Format("{0, 8} |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].iManv));
            Console.Write(string.Format(" {0, -19} |", dsbanve[vt].sHoten));
            Console.Write(string.Format(" {0, -15} |", dsbanve[vt].sCMND));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].iNamsinh));
            Console.Write(string.Format(" {0, -12} |", dsbanve[vt].dNgaycong));
            Console.Write(string.Format(" {0, -15} |", dsbanve[vt].sSocalamviec));
            Console.Write(string.Format(" {0, -19} |", dsbanve[vt].iLuongcb));
            Console.WriteLine(string.Format(" {0, -20} |", dsbanve[vt].iLuong + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
