using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    class Ngoaithanh : Chuyenxe,CapnhatDoanhthuvasove
    {
        private int iSovedaban;
        private int iHaophi;
        private string sNoidi;
        private string sNoiden;
        private string sThoigiandi;
        private string sNgaydi;
        private List<Ngoaithanh> ldsNgoaithanh = new List<Ngoaithanh>();
        //
        public List<Ngoaithanh> dsNgoaithanh
        {
            get { return this.ldsNgoaithanh; }
            set { this.ldsNgoaithanh = value; }
        }
        public int Sovedaban
        {
            get { return this.iSovedaban; }
            set { this.iSovedaban = value; }
        }
        public int Haophi
        {
            get { return this.iHaophi; }
            set { this.iHaophi = value; }
        }
        public string Noidi
        {
            get { return this.sNoidi; }
            set { this.sNoidi = value; }
        }
        public string Noiden
        {
            get { return this.sNoiden; }
            set { this.sNoiden = value; }
        }
        public string Thoigiandi
        {
            get { return this.sThoigiandi; }
            set { this.sThoigiandi = value; }
        }
        public string Ngaydi
        {
            get { return this.sNgaydi; }
            set { this.sNgaydi = value; }
        }
        public Ngoaithanh() : base()
        {

        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap noi di: ");
            this.sNoidi = Console.ReadLine();
            Console.Write("Nhap noi den: ");
            this.sNoiden = Console.ReadLine();
            Console.Write("Nhap thoi gian di: ");
            this.sThoigiandi = Console.ReadLine();
            Console.Write("Nhap ngay di: ");
            this.sNgaydi = Console.ReadLine();
            this.iSovedaban = 0;
            Console.Write("Nhap hao phi: ");
            this.iHaophi = int.Parse(Console.ReadLine());
            this.Doanhthu = 0;
            this.Doanhthu = Tinhdoanhthu();
        
          }

        public override void Xuat()
        {
            Console.WriteLine("     -----------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NGOẠI THÀNH---------------------------------------------------------------------------------");
            Console.WriteLine("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -12} |", "Biển số"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé đã bán"));
            Console.Write(string.Format(" {0, -12} |", "Hao phí"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                Console.Write(string.Format("{0,8 } |", i + 1));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iMaso));
                Console.Write(string.Format(" {0, -19} |", dsNgoaithanh[i].sTentaixe));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sBienso));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNoidi));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNoiden));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sThoigiandi));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNgaydi));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iGiave));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iSove));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iSovedaban));
                Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iHaophi));
                Console.WriteLine(string.Format(" {0, -12} |", dsNgoaithanh[i].iDoanhthu));
                Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }

        public override void GhifileTxt(string filename)
        {
            FileStream fnv = new FileStream(filename, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                swrite.WriteLine(dsNgoaithanh[i].Maso);
                swrite.WriteLine(dsNgoaithanh[i].Tentaixe);
                swrite.WriteLine(dsNgoaithanh[i].Bienso);
                swrite.WriteLine(dsNgoaithanh[i].Noidi);
                swrite.WriteLine(dsNgoaithanh[i].Noiden);
                swrite.WriteLine(dsNgoaithanh[i].Thoigiandi);
                swrite.WriteLine(dsNgoaithanh[i].Ngaydi);
                swrite.WriteLine(dsNgoaithanh[i].Giave);
                swrite.WriteLine(dsNgoaithanh[i].Sove);
                swrite.WriteLine(dsNgoaithanh[i].Sovedaban);
                swrite.WriteLine(dsNgoaithanh[i].Haophi);
                swrite.WriteLine(dsNgoaithanh[i].Doanhthu);

            }
            swrite.Flush();
            dsNgoaithanh = new List<Ngoaithanh>();
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
            int size = dem / 12;
            rd.Close();
            fp.Close();
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader rd1 = new StreamReader(fp1, Encoding.UTF8);
            for (int i = 0; i < size; i++)
            {
                Ngoaithanh lx = new Ngoaithanh();
                lx.Maso = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Tentaixe = rd1.ReadLine();
                lx.Bienso = rd1.ReadLine();
                lx.Noidi = rd1.ReadLine();
                lx.Noiden = rd1.ReadLine();
                lx.Thoigiandi = rd1.ReadLine();
                lx.Ngaydi = rd1.ReadLine();
                lx.Giave = double.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Sove = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Sovedaban = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Haophi = int.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Doanhthu = double.Parse(rd1.ReadLine().Replace("\\uFEFF", ""));
                dsNgoaithanh.Add(lx);
            }
            fp1.Close();
            rd1.Close();
        }
        public override void Them()
        {
            int n;
            Console.Write("So Chuyen xe noi thanh muon nhap: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Ngoaithanh lx = new Ngoaithanh();
                lx.Nhap();
                dsNgoaithanh.Add(lx);
            }
        }

        public override void Sua(int temp)
        {
            temp = temp - 1;
            Ngoaithanh lxmoi = new Ngoaithanh();
            lxmoi.Nhap();
            dsNgoaithanh[temp] = lxmoi;
        }

        public override void Xoa(int temp)
        {
            List<Ngoaithanh> tam = dsNgoaithanh;
            dsNgoaithanh = new List<Ngoaithanh>();
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
                Ngoaithanh TT = new Ngoaithanh();
                if (i != temp)
                {
                    TT = tam[i];
                    dsNgoaithanh.Add(TT);
                }
                else
                {
                    Vexe vx = new Vexe();
                    vx.DocfileTxt("dsvx.txt");
                    vx.Xoavexetheomachuyen(tam[i].Maso);
                    vx.GhifileTxt("dsvx.txt");
                }
            }
        }
        public static bool operator >(Ngoaithanh a, Ngoaithanh b)
        {
            if (a.Doanhthu < b.Doanhthu) return false;
            return true;
        }
        public static bool operator <(Ngoaithanh a, Ngoaithanh b)
        {
            if (a.Doanhthu > b.Doanhthu) return false;
            return true;
        }
        public override void Sort()
        {
            Ngoaithanh t;
            for (int i = 0; i < dsNgoaithanh.Count - 1; i++)
            {
                for (int j = i + 1; j < dsNgoaithanh.Count; j++)
                {
                    if (dsNgoaithanh[i] > dsNgoaithanh[j])
                    {
                        t = dsNgoaithanh[i];
                        dsNgoaithanh[i] = dsNgoaithanh[j];
                        dsNgoaithanh[j] = t;
                    }
                }
            }
            GhifileTxt("dsngoaithanh.txt");
            dsNgoaithanh = new List<Ngoaithanh>();
        }

        public override void Search()
        {
            int dem1 = 0;
            Console.WriteLine("Nhập mã chuyến cần tìm: ");
            int NV = int.Parse(Console.ReadLine());
            Console.WriteLine("     ------------------------------------------------------------------------------------------DANH SÁCH TÌM KIẾM THEO MÃ CHUYẾN------------------------------------------------------------------------");
            Console.WriteLine("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -12} |", "Biển số"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé đã bán"));
            Console.Write(string.Format(" {0, -12} |", "Hao phí"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                if (dsNgoaithanh[i].iMaso == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0,8 } |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iMaso));
                    Console.Write(string.Format(" {0, -19} |", dsNgoaithanh[i].sTentaixe));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sBienso));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNoidi));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNoiden));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sThoigiandi));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].sNgaydi));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iGiave));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iSove));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iSovedaban));
                    Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[i].iHaophi));
                    Console.WriteLine(string.Format(" {0, -12} |", dsNgoaithanh[i].iDoanhthu));
                    Console.WriteLine("    ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            if (dem1 == 0) Console.WriteLine("                                                                                      ---> không tìm thấy <--- ");
        }
        public override void chuyenmax()
        {
            Console.WriteLine("     --------------------------------------------------------------------------------------CHUYẾN CÓ DOANH THU CAO NHẤT---------------------------------------------------------------------");
            Console.WriteLine("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -12} |", "Biển số"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé đã bán"));
            Console.Write(string.Format(" {0, -12} |", "Hao phí"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            double maxve = 0;
            int vt = 0;
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                if (dsNgoaithanh[i].iDoanhthu > maxve)
                {
                    maxve = dsNgoaithanh[i].iDoanhthu;
                    vt = i;
                }
            }
            Console.Write(string.Format("{0,8 } |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iMaso));
            Console.Write(string.Format(" {0, -19} |", dsNgoaithanh[vt].sTentaixe));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sBienso));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNoidi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNoiden));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sThoigiandi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNgaydi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iGiave));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iSove));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iSovedaban));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iHaophi));
            Console.WriteLine(string.Format(" {0, -12} |", dsNgoaithanh[vt].iDoanhthu));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
        public override void chuyenmin()
        {
            Console.WriteLine("     --------------------------------------------------------------------------------------CHUYẾN CÓ DOANH THU THẤP NHẤT---------------------------------------------------------------------");
            Console.WriteLine("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -19} |", "Tên tài xế "));
            Console.Write(string.Format(" {0, -12} |", "Biển số"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.Write(string.Format(" {0, -12} |", "Gía vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé"));
            Console.Write(string.Format(" {0, -12} |", "Số vé đã bán"));
            Console.Write(string.Format(" {0, -12} |", "Hao phí"));
            Console.WriteLine(string.Format(" {0, -12} |", "Doanh thu"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            double maxve = dsNgoaithanh[0].iDoanhthu;
            int vt = 0;
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                if (dsNgoaithanh[i].iDoanhthu < maxve)
                {
                    maxve = dsNgoaithanh[i].iDoanhthu;
                    vt = i;
                }
            }
            Console.Write(string.Format("{0,8 } |", vt + 1));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iMaso));
            Console.Write(string.Format(" {0, -19} |", dsNgoaithanh[vt].sTentaixe));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sBienso));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNoidi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNoiden));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sThoigiandi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].sNgaydi));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iGiave));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iSove));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iSovedaban));
            Console.Write(string.Format(" {0, -12} |", dsNgoaithanh[vt].iHaophi));
            Console.WriteLine(string.Format(" {0, -12} |", dsNgoaithanh[vt].iDoanhthu));
            Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
        public void Capnhatsaukhixoa(int machuyen, double giave)
        {
            int temp;
            Ngoaithanh nt1 = new Ngoaithanh();
            Ngoaithanh nt2 = new Ngoaithanh();
            nt1.DocfileTxt("dsngoaithanh.txt");
            temp = nt1.Searchmachuyen(machuyen);
            nt2 = nt1.ReturnNgoaithanh(temp + 1);
            nt2.Sovedaban = nt2.Sovedaban - 1;
            nt2.Doanhthu = nt2.Doanhthu - giave;
            nt1.Suasovedabanvadoanhthu(nt2, temp + 1);
            nt1.GhifileTxt("dsngoaithanh.txt");

        }
        public override double Tinhdoanhthu()
        {
            return this.Doanhthu = this.Doanhthu - this.Haophi;
        }
        public void Suasovedabanvadoanhthu(Ngoaithanh sua, int temp)
        {
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                if (i == temp - 1)
                {
                    dsNgoaithanh[i] = sua;
                }
            }
        }

        public int Searchmachuyen(int machuyen)
        {
            int tam = 0;
            Ngoaithanh nt = new Ngoaithanh();
            for (int i = 0; i < dsNgoaithanh.Count; i++)
            {
                if (dsNgoaithanh[i].Maso == machuyen) tam = i;
            }
            return tam;
        }

        public Ngoaithanh ReturnNgoaithanh(int temp)
        {
            Ngoaithanh tam = new Ngoaithanh();
            for (int i = 0; i < temp; i++)
            {
                tam = dsNgoaithanh[i];
            }
            return tam;
        }
    }
}
