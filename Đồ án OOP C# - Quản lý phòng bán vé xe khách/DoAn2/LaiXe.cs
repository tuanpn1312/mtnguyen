using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    public class LaiXe : NhanVien
    {
        private int dPhucap;
        private List<LaiXe> ldslaixe = new List<LaiXe>();
        //
        public int Phucap
        {
            get { return this.dPhucap; }
            set { this.dPhucap = value; }
        }
        public List<LaiXe> dslaixe
        {
            get { return this.ldslaixe; }
            set { this.ldslaixe = value; }
        }
        public LaiXe() : base()
        {

        }
        //
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap phu cap: ");
            this.dPhucap = int.Parse(Console.ReadLine());
            this.iLuong = tinhluong();
        }
        //
        public override void Xuat()
        {
            Console.WriteLine("     -----------------------------------------------------DANH SÁCH NHÂN VIÊN LÁI XE-------------------------------------------------------");
            Console.WriteLine("     ______________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dslaixe.Count; i++)
            {
                Console.Write(string.Format("{0, 8} |", i + 1));
                Console.Write(string.Format(" {0, -12} |", dslaixe[i].iManv));
                Console.Write(string.Format(" {0, -19} |", dslaixe[i].sHoten));
                Console.Write(string.Format(" {0, -15} |", dslaixe[i].sCMND));
                Console.Write(string.Format(" {0, -12} |", dslaixe[i].iNamsinh));
                Console.Write(string.Format(" {0, -12} |", dslaixe[i].dNgaycong));
                Console.Write(string.Format(" {0, -19} |", dslaixe[i].iLuongcb));
                Console.WriteLine(string.Format(" {0, -20} |", dslaixe[i].iLuong + " $"));
                Console.WriteLine("    ------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        //
        public override int tinhluong()
        {
            this.iLuong = this.dNgaycong * this.Phucap + this.iLuong;
            return this.iLuong;
        }
        public override void GhifileNv(String filename)
        {
            FileStream fnv = new FileStream(filename, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            for (int i = 0; i < dslaixe.Count; i++)
            {
                swrite.WriteLine(dslaixe[i].Manv);
                swrite.WriteLine(dslaixe[i].Hoten);
                swrite.WriteLine(dslaixe[i].CMND);
                swrite.WriteLine(dslaixe[i].Namsinh);
                swrite.WriteLine(dslaixe[i].Ngaycong);
                swrite.WriteLine(dslaixe[i].Luongcb);
                swrite.WriteLine(dslaixe[i].Phucap);
                swrite.WriteLine(dslaixe[i].Luong);
            }
            swrite.Flush();
            dslaixe = new List<LaiXe>();
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
                LaiXe lx = new LaiXe();
                lx.Manv = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Hoten = rd1.ReadLine();
                lx.CMND = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Namsinh = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Ngaycong = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Luongcb = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Phucap = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Luong = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                dslaixe.Add(lx);
            }
            fp1.Close();
            rd1.Close();
        }
        public override void Them()
        {
            int n;
            Console.Write("So nhan vien lai xe muon nhap: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                LaiXe lx = new LaiXe();
                lx.Nhap();
                dslaixe.Add(lx);
            }
        }
        public override void Xoa(int temp)
        {
            List<LaiXe> tam = dslaixe;
            dslaixe = new List<LaiXe>();
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
                LaiXe TT = new LaiXe();
                if (i != temp)
                {
                    TT = tam[i];
                    dslaixe.Add(TT);
                }
            }
        }
        public override void Sua(int temp)
        {
            temp = temp - 1;
            LaiXe lxmoi = new LaiXe();
            lxmoi.Nhap();
            dslaixe[temp] = lxmoi;
        }
        public static bool operator >(LaiXe a, LaiXe b)
        {
            if (a.iLuong < b.iLuong) return false;
            return true;
        }
        public static bool operator <(LaiXe a, LaiXe b)
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
            for (int i = 0; i < dslaixe.Count; i++)
            {
                if (dslaixe[i].Manv == NV1)
                {
                    dem++;
                    vt1 = i;
                }
                if (dslaixe[i].Manv == NV2)
                {
                    dem++;
                    vt2 = i;
                }
            }
            if (dem <= 1) Console.WriteLine("---> không tìm thấy <--- ");
            if (dem > 1)
            {
                if (dslaixe[vt1] > dslaixe[vt2]) Console.WriteLine("Chuyến có mã " + dslaixe[vt1].Hoten + " lớn hơn " + dslaixe[vt2].Hoten);
                if (dslaixe[vt1] < dslaixe[vt2]) Console.WriteLine("Chuyến có mã " + dslaixe[vt1].Hoten + " bé hơn " + dslaixe[vt2].Hoten);
                if (dslaixe[vt1] == dslaixe[vt2]) Console.WriteLine("Chuyến có mã " + dslaixe[vt1].Hoten + " bằng " + dslaixe[vt2].Hoten);
               
            }
        }
        public override void sort()
        {
            LaiXe t;
            for (int i = 0; i < dslaixe.Count - 1; i++)
            {
                for (int j = i + 1; j < dslaixe.Count; j++)
                {
                    if (dslaixe[i] > dslaixe[j])
                    {
                        t = dslaixe[i];
                        dslaixe[i] = dslaixe[j];
                        dslaixe[j] = t;
                    }
                }
            }
            GhifileNv("dslaixe.txt");
            dslaixe = new List<LaiXe>();
        }
        public override void search()
        {
            int dem1 = 0;
            Console.WriteLine("Nhập họ và tên nhân viên lái xe cần tìm: ");
            string NV = Console.ReadLine();
            Console.WriteLine("     _________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dslaixe.Count; i++)
            {
                if (dslaixe[i].sHoten == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0, 8} |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dslaixe[i].iManv));
                    Console.Write(string.Format(" {0, -19} |", dslaixe[i].sHoten));
                    Console.Write(string.Format(" {0, -15} |", dslaixe[i].sCMND));
                    Console.Write(string.Format(" {0, -12} |", dslaixe[i].iNamsinh));
                    Console.Write(string.Format(" {0, -12} |", dslaixe[i].dNgaycong));
                    Console.Write(string.Format(" {0, -19} |", dslaixe[i].iLuongcb));
                    Console.WriteLine(string.Format(" {0, -20} |", dslaixe[i].iLuong + " $"));
                    Console.WriteLine("   ----------------------------------------------------------------------------------------------------------------------------------");
                }
            }
                if (dem1 == 0) Console.WriteLine("---> không tìm thấy <--- ");
            
        }
        public override void luongmax()
        {
            Console.WriteLine("     _____________________________________________________NHÂN VIÊN CÓ LƯƠNG CAO NHẤT_______________________________________________________");

            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------");
            double maxve = 0;
            int vt = 0;
            for (int i = 0; i < dslaixe.Count; i++)
            {
                if (dslaixe[i].tinhluong() > maxve)
                {
                    maxve = dslaixe[i].tinhluong();
                    vt = i;
                }
            }
            Console.Write(string.Format("{0, 8} |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].iManv));
            Console.Write(string.Format(" {0, -19} |", dslaixe[vt].sHoten));
            Console.Write(string.Format(" {0, -15} |", dslaixe[vt].sCMND));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].iNamsinh));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].dNgaycong));
            Console.Write(string.Format(" {0, -19} |", dslaixe[vt].iLuongcb));
            Console.WriteLine(string.Format(" {0, -20} |", dslaixe[vt].iLuong + " $"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------");
        }

        public override void luongmin()
        {
            Console.WriteLine("     ______________________________________________________NHÂN VIÊN CÓ LƯƠNG THẤP NHẤT_____________________________________________________");

            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã nhân viên"));
            Console.Write(string.Format(" {0, -19} |", "Họ và tên "));
            Console.Write(string.Format(" {0, -15} |", "Số CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Ngày công"));
            Console.Write(string.Format(" {0, -19} |", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -20} |", "Lương chính thức" + " $"));
            Console.WriteLine("    ---------------------------------------------------------------------------------------------------------------------------------------");
            double maxve = dslaixe[0].tinhluong();
            int vt = 0;
            for (int i = 0; i < dslaixe.Count; i++)
            {
                if (dslaixe[i].tinhluong() < maxve)
                {
                    maxve = dslaixe[i].tinhluong();
                    vt = i;
                }
            }
            Console.Write(string.Format("{0, 8} |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].iManv));
            Console.Write(string.Format(" {0, -19} |", dslaixe[vt].sHoten));
            Console.Write(string.Format(" {0, -15} |", dslaixe[vt].sCMND));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].iNamsinh));
            Console.Write(string.Format(" {0, -12} |", dslaixe[vt].dNgaycong));
            Console.Write(string.Format(" {0, -19} |", dslaixe[vt].iLuongcb));
            Console.WriteLine(string.Format(" {0, -20} |", dslaixe[vt].iLuong + " $"));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
