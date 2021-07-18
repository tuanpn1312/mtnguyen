using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    class Noithanh : Chuyenxe
    {
        private string sLotrinh;
        private string sTenbanve;
        private int iSokm;
        private int iSovebanduoc;
        private List<Noithanh> ldsNoithanh = new List<Noithanh>();
        //
        public int Sokm
        {
            get { return this.iSokm; }
            set { this.iSokm = value; }
        }
        public string Tenbanve
        {
            get { return this.sTenbanve; }
            set { this.sTenbanve = value; }
        }
        public string Lotrinh
        {
            get { return this.sLotrinh; }
            set { this.sLotrinh = value; }
        }
        public int Sovebanduoc
        {
            get { return this.iSovebanduoc; }
            set { this.iSovebanduoc = value; }
        }
        public List<Noithanh> dsNoithanh
        {
            get { return this.ldsNoithanh; }
            set { this.ldsNoithanh = value; }
        }
        //
        public Noithanh() : base()
        {

        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap lo trinh: ");
            this.sLotrinh = Console.ReadLine();
            Console.Write("Nhập chiều dài quãng đường: ");
            this.iSokm = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten nhan vien ban ve: ");
            this.sTenbanve = Console.ReadLine();
            Console.Write("Nhap so ve da ban duoc: ");
            this.iSovebanduoc = int.Parse(Console.ReadLine());
            this.Doanhthu = Tinhdoanhthu();
        }


        public override void Xuat()
        {
            Console.WriteLine("     -------------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NỘI THÀNH---------------------------------------------------------------------");
            Console.WriteLine("     ________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -15} |", "Biển số"));
            Console.Write(string.Format(" {0, -18} |", "Lộ trình"));
            Console.Write(string.Format(" {0, -15} |", "Quãng đường"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -15} |", "Số vé bán được"));
            Console.Write(string.Format(" {0, -18} |", "Tên bán vé"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsNoithanh.Count; i++)
            {
                Console.Write(string.Format("{0,8 } |", i + 1));
                Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iMaso));
                Console.Write(string.Format(" {0, -19} |", dsNoithanh[i].sTentaixe));
                Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].sBienso));
                Console.Write(string.Format(" {0, -18} |", dsNoithanh[i].sLotrinh));
                Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].iSokm));
                Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iGiave));
                Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iSove));
                Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].iSovebanduoc));
                Console.Write(string.Format(" {0, -18} |", dsNoithanh[i].sTenbanve));
                Console.WriteLine(string.Format(" {0, -12} |", dsNoithanh[i].iDoanhthu));
                Console.WriteLine("    -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        public override void GhifileTxt(string filename)
        {
            FileStream fnv = new FileStream(filename, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            for (int i = 0; i < dsNoithanh.Count; i++)
            {
                swrite.WriteLine(dsNoithanh[i].Maso);
                swrite.WriteLine(dsNoithanh[i].Tentaixe);
                swrite.WriteLine(dsNoithanh[i].Bienso);
                swrite.WriteLine(dsNoithanh[i].Lotrinh);
                swrite.WriteLine(dsNoithanh[i].Sokm);
                swrite.WriteLine(dsNoithanh[i].Giave);
                swrite.WriteLine(dsNoithanh[i].Sove);
                swrite.WriteLine(dsNoithanh[i].Sovebanduoc);
                swrite.WriteLine(dsNoithanh[i].Tenbanve);
                swrite.WriteLine(dsNoithanh[i].Doanhthu);

            }
            swrite.Flush();
            dsNoithanh = new List<Noithanh>();
            fnv.Close();
        }

        public override void DocfileTxt(string filename)
        {
            FileStream fp = new FileStream(filename, FileMode.Open);
            StreamReader rd = new StreamReader(fp, Encoding.UTF8);
            int dem = 0;
            while (rd.ReadLine() != null)
            {
                dem++;
            }
            int size = dem / 10;
            rd.Close();
            fp.Close();
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader rd1 = new StreamReader(fp1, Encoding.UTF8);
            for (int i = 0; i < size; i++)
            {
                Noithanh lx = new Noithanh();
                lx.Maso = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Tentaixe = rd1.ReadLine();
                lx.Bienso = rd1.ReadLine();
                lx.Lotrinh = rd1.ReadLine();
                lx.Sokm = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Giave = double.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Sove = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Sovebanduoc = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Tenbanve = rd1.ReadLine();
                lx.Doanhthu = double.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                dsNoithanh.Add(lx);
            }
            fp1.Close();
            rd1.Close();
        }

        public override double Tinhdoanhthu()
        {
            return this.Sovebanduoc * this.Giave;
        }

        public override void Them()
        {
            int n;
            Console.Write("So Chuyen xe noi thanh muon nhap: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Noithanh lx = new Noithanh();
                lx.Nhap();
                dsNoithanh.Add(lx);
            }
        }

        public override void Sua(int temp)
        {
            temp = temp - 1;
            Noithanh lxmoi = new Noithanh();
            lxmoi.Nhap();
            dsNoithanh[temp] = lxmoi;
        }

        public override void Xoa(int temp)
        {
            List<Noithanh> tam = dsNoithanh;
            dsNoithanh = new List<Noithanh>();
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
                Noithanh TT = new Noithanh();
                if (i != temp)
                {
                    TT = tam[i];
                    dsNoithanh.Add(TT);
                }
            }
        }
        public static bool operator >(Noithanh a, Noithanh b)
        {
            if (a.Tinhdoanhthu() < b.Tinhdoanhthu()) return false;
            return true;
        }
        public static bool operator <(Noithanh a, Noithanh b)
        {
            if (a.Tinhdoanhthu() > b.Tinhdoanhthu()) return false;
            return true;
        }
        public override void Sort()
        {
            Noithanh t;
            for (int i = 0; i < dsNoithanh.Count - 1; i++)
            {
                for (int j = i + 1; j < dsNoithanh.Count; j++)
                {
                    if (dsNoithanh[i] > dsNoithanh[j])
                    {
                        t = dsNoithanh[i];
                        dsNoithanh[i] = dsNoithanh[j];
                        dsNoithanh[j] = t;
                    }
                }
            }
            GhifileTxt("dsnoithanh.txt");
            dsNoithanh = new List<Noithanh>();
        }

        public override void Search()
        {
            int dem1 = 0;
            Console.WriteLine("Nhập mã chuyến cần tìm: ");
            int NV = int.Parse(Console.ReadLine());
            Console.WriteLine("     ------------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NỘI THÀNH---------------------------------------------------------------");
            Console.WriteLine("     _______________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -15} |", "Biển số"));
            Console.Write(string.Format(" {0, -18} |", "Lộ trình"));
            Console.Write(string.Format(" {0, -15} |", "Quãng đường"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -15} |", "Số vé bán được"));
            Console.Write(string.Format(" {0, -18} |", "Tên bán vé"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsNoithanh.Count; i++)
            {
                if (dsNoithanh[i].iMaso == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0,8 } |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iMaso));
                    Console.Write(string.Format(" {0, -19} |", dsNoithanh[i].sTentaixe));
                    Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].sBienso));
                    Console.Write(string.Format(" {0, -18} |", dsNoithanh[i].sLotrinh));
                    Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].iSokm));
                    Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iGiave));
                    Console.Write(string.Format(" {0, -12} |", dsNoithanh[i].iSove));
                    Console.Write(string.Format(" {0, -15} |", dsNoithanh[i].iSovebanduoc));
                    Console.Write(string.Format(" {0, -18} |", dsNoithanh[i].sTenbanve));
                    Console.WriteLine(string.Format(" {0, -12} |", dsNoithanh[i].iDoanhthu));
                    Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                }
            }
            if (dem1 == 0) Console.WriteLine("---> không tìm thấy <--- ");
        }
        public override void chuyenmax()
        {
            Console.WriteLine("     ------------------------------------------------------------------------------------CHUYẾN NỘI THÀNH CÓ DOANH THU CAO NHẤT-------------------------------------------------------");
            Console.WriteLine("     _______________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -15} |", "Biển số"));
            Console.Write(string.Format(" {0, -18} |", "Lộ trình"));
            Console.Write(string.Format(" {0, -15} |", "Quãng đường"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -15} |", "Số vé bán được"));
            Console.Write(string.Format(" {0, -18} |", "Tên bán vé"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            double maxve = 0;
            int vt = 0;
            for (int i = 0; i < dsNoithanh.Count; i++)
            {
                if (dsNoithanh[i].iDoanhthu > maxve)
                {
                    maxve = dsNoithanh[i].iDoanhthu;
                    vt = i;
                }
            }
            Console.Write(string.Format("{0,8 } |", vt+ 1));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iMaso));
            Console.Write(string.Format(" {0, -19} |", dsNoithanh[vt].sTentaixe));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].sBienso));
            Console.Write(string.Format(" {0, -18} |", dsNoithanh[vt].sLotrinh));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].iSokm));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iGiave));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iSove));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].iSovebanduoc));
            Console.Write(string.Format(" {0, -18} |", dsNoithanh[vt].sTenbanve));
            Console.WriteLine(string.Format(" {0, -12} |", dsNoithanh[vt].iDoanhthu));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
        public override void chuyenmin()
        {
            Console.WriteLine("     ------------------------------------------------------------------------------------CHUYẾN NỘI THÀNH CÓ DOANH THU THẤP NHẤT-------------------------------------------------------");
            Console.WriteLine("     _______________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -15} |", "Biển số"));
            Console.Write(string.Format(" {0, -18} |", "Lộ trình"));
            Console.Write(string.Format(" {0, -15} |", "Quãng đường"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -15} |", "Số vé bán được"));
            Console.Write(string.Format(" {0, -18} |", "Tên bán vé"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            double maxve = dsNoithanh[0].iDoanhthu;
            int vt = 0;
            for (int i = 0; i < dsNoithanh.Count; i++)
            {
                if (dsNoithanh[i].iDoanhthu < maxve)
                {
                    maxve = dsNoithanh[i].iDoanhthu;
                    vt = i;
                }
            }
            Console.Write(string.Format("{0,8 } |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iMaso));
            Console.Write(string.Format(" {0, -19} |", dsNoithanh[vt].sTentaixe));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].sBienso));
            Console.Write(string.Format(" {0, -18} |", dsNoithanh[vt].sLotrinh));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].iSokm));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iGiave));
            Console.Write(string.Format(" {0, -12} |", dsNoithanh[vt].iSove));
            Console.Write(string.Format(" {0, -15} |", dsNoithanh[vt].iSovebanduoc));
            Console.Write(string.Format(" {0, -18} |", dsNoithanh[vt].sTenbanve));
            Console.WriteLine(string.Format(" {0, -12} |", dsNoithanh[vt].iDoanhthu));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
