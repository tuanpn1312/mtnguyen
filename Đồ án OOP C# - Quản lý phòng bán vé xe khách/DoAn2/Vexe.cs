using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    class Vexe
    {
        private int iMave;
        private string sTenkhachhang;
        private string sLoaiKH;
        private int iCMND;
        private int iNamsinh;
        private int iMachuyen;
        private int iSoghe;
        private double iGiave;
        private string sNoidi;
        private string sNoiden;
        private string sNgaydi;
        private string sThoigiandi;
        private string sBienso;
        private List<Vexe> ldsvx = new List<Vexe>();
        private List<Ngoaithanh> ldsnt = new List<Ngoaithanh>();
        private Ngoaithanh nt = new Ngoaithanh();
        //
        public List<Vexe> dsvx
        {
            get { return this.ldsvx; }
            set { this.ldsvx = value; }
        }
        public int Mave
        {
            get { return this.iMave; }
            set { this.iMave = value; }
        }
        public string Tenkhachhang
        {
            get { return this.sTenkhachhang; }
            set { this.sTenkhachhang = value; }
        }
        public string LoaiKh
        {
            get { return this.sLoaiKH; }
            set { this.sLoaiKH = value; }
        }
        public int CMND
        {
            get { return this.iCMND; }
            set { this.iCMND = value; }
        }
        public int Namsinh
        {
            get { return this.iNamsinh; }
            set { this.iNamsinh = value; }
        }
        public int Machuyen
        {
            get { return this.iMachuyen; }
            set { this.iMachuyen = value; }
        }
        public int Soghe
        {
            get { return this.iSoghe; }
            set { this.iSoghe = value; }
        }
        public double Giave
        {
            get { return this.iGiave; }
            set { this.iGiave = value; }
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
        public string Ngaydi
        {
            get { return this.sNgaydi; }
            set { this.sNgaydi = value; }
        }
        public string Thoigiandi
        {
            get { return this.sThoigiandi; }
            set { this.sThoigiandi = value; }
        }
        public string Bienso
        {
            get { return this.sBienso; }
            set { this.sBienso = value; }
        }
        //
        public void Nhap()
        {
            int kiemtra;
            Console.Write("Nhập mã vé: ");
            this.iMave = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên khách hàng: ");
            this.sTenkhachhang = Console.ReadLine();
            Console.Write("Nhập CMND: ");
            this.iCMND = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập năm sinh: ");
            this.iNamsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chế độ giảm giá vé: ");
            Console.WriteLine("NL: Người lớn (0%)    TE/NG: Trẻ em/Người già (50%)  SV: Sinh viên (30%)     KT: Khuyết tật (70%)");
            Console.Write("Nhập loại khách hàng: ");
            this.sLoaiKH = Console.ReadLine();
            Console.Clear();
            nt.DocfileTxt("dsngoaithanh.txt");  //đọc ds ngoại thành vào nt để xuất ra màn hình để chọn
            nt.Xuat();
            Console.Write("Chọn chuyến xe muốn đi: ");
            int temp = int.Parse(Console.ReadLine());
            Ngoaithanh nt1 = new Ngoaithanh();
            nt1 = nt.ReturnNgoaithanh(temp);        // hàm returnNgoaithanh sẽ trả về đối tượng Ngoại thành mà bạn đã chọn
            this.iMachuyen = nt1.Maso;               //gán giá trị của đối tượn ngoại thành đã chọn vào Vé xe
            this.Soghe = nt1.Sovedaban + 1;
            nt1.Sovedaban = nt1.Sovedaban + 1;      // cập nhật lại giá trị số vé đã bán, mỗi lần bán thì tăng lên 1 

                if (this.LoaiKh == "SV") this.Giave = nt1.Giave * 0.7;                          //điều kiện giảm giá vé
                if (this.LoaiKh == "KT") this.Giave = nt1.Giave * 0.3;
                if (this.LoaiKh == "TE" || this.LoaiKh == "NG") this.Giave = nt1.Giave * 0.5;
                if (this.LoaiKh == "NL") this.Giave = nt1.Giave;
                nt1.Doanhthu = nt1.Doanhthu + this.Giave;  // cập nhật lại doanh thu chuyến ngoại thành
                this.Noidi = nt1.Noidi;
                this.Noiden = nt1.Noiden;
                this.Ngaydi = nt1.Ngaydi;
                this.Thoigiandi = nt1.Thoigiandi;
                this.Bienso = nt1.Bienso;
                nt.Suasovedabanvadoanhthu(nt1, temp);                 //hàm cập nhật lại đối tượng ngoại thành đã chọn ở trên trong danh sách Chuyến ngoại thành
                nt.GhifileTxt("dsngoaithanh.txt");
            
        }
        public void Xuat()
        {
            Console.WriteLine("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
            Console.WriteLine("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã vé"));
            Console.Write(string.Format(" {0, -19} |", "Tên khách hàng "));
            Console.Write(string.Format(" {0, -12} |", "CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Loại KH"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -12} |", "Biển số xe"));
            Console.Write(string.Format(" {0, -12} |", "Số ghế"));
            Console.Write(string.Format(" {0, -12} |", "Giá vé"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.WriteLine(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsvx.Count; i++)
            {
                Console.Write(string.Format("{0,8 } |", i + 1));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Mave));
                Console.Write(string.Format(" {0, -19} |", dsvx[i].Tenkhachhang));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].CMND));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Namsinh));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].LoaiKh));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Machuyen));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Bienso));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Soghe));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Giave));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Noidi));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Noiden));
                Console.Write(string.Format(" {0, -12} |", dsvx[i].Ngaydi));
                Console.WriteLine(string.Format(" {0, -12} |", dsvx[i].Thoigiandi));
                Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        public void Them()
        {
            int kiemtra;
            Vexe vx = new Vexe();
            vx.Nhap();
            dsvx.Add(vx);

        }

        public void Xoa(int temp)
        {
            List<Vexe> tam = dsvx;
            dsvx = new List<Vexe>();
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
                if (i != temp)
                {
                    Vexe TT = new Vexe();
                    TT = tam[i];
                    dsvx.Add(TT);
                    
                }
                else
                {
                    int tt = tam[i].Machuyen;   // trả về mã chuyến của vé xe đã xóa
                    double temp1 = tam[i].Giave;    // trả về giá vé của vé xe đã xóa
                    nt.Capnhatsaukhixoa(tt,temp1);  //tiến hành cập nhật lại doanh thu và số vé đã bán trong danh sách chuyến đi

                }
            }

        }

        public void Sua(int temp)
        {
            temp = temp - 1;
            Vexe bvmoi = new Vexe();
            bvmoi.Nhap();
            dsvx[temp] = bvmoi;
        }
        public void GhifileTxt(string filename)
        {
            FileStream fnv = new FileStream(filename, FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            for (int i = 0; i < dsvx.Count; i++)
            {
                swrite.WriteLine(dsvx[i].Mave);
                swrite.WriteLine(dsvx[i].Tenkhachhang);
                swrite.WriteLine(dsvx[i].CMND);
                swrite.WriteLine(dsvx[i].Namsinh);
                swrite.WriteLine(dsvx[i].LoaiKh);
                swrite.WriteLine(dsvx[i].Machuyen);
                swrite.WriteLine(dsvx[i].Bienso);
                swrite.WriteLine(dsvx[i].Soghe);
                swrite.WriteLine(dsvx[i].Giave);
                swrite.WriteLine(dsvx[i].Noidi);
                swrite.WriteLine(dsvx[i].Noiden);
                swrite.WriteLine(dsvx[i].Ngaydi);
                swrite.WriteLine(dsvx[i].Thoigiandi);
            }
            swrite.Flush();
            dsvx = new List<Vexe>();
            fnv.Close();
        }
        public void DocfileTxt(string filename)
        {
            FileStream fp = new FileStream(filename, FileMode.Open);
            StreamReader rd = new StreamReader(fp, Encoding.UTF8);
            int dem = 0;
            while (rd.ReadLine() != null)
            {
                dem++;
            }
            int size = dem / 13;
            rd.Close();
            fp.Close();
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader rd1 = new StreamReader(fp1, Encoding.UTF8);
            for (int i = 0; i < size; i++)
            {
                Vexe lx = new Vexe();
                lx.Mave = Convert.ToInt32(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Tenkhachhang = rd1.ReadLine();
                lx.CMND = Convert.ToInt32(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Namsinh = Convert.ToInt32(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.LoaiKh = rd1.ReadLine();
                lx.Machuyen = Convert.ToInt32(rd1.ReadLine().Replace("\\uFEFF", "")); ;
                lx.Bienso = rd1.ReadLine();
                lx.Soghe = Convert.ToInt32(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Giave = Convert.ToDouble(rd1.ReadLine().Replace("\\uFEFF", ""));
                lx.Noidi = rd1.ReadLine();
                lx.Noiden = rd1.ReadLine();
                lx.Ngaydi = rd1.ReadLine();
                lx.Thoigiandi = rd1.ReadLine();
                dsvx.Add(lx);
            }
            fp1.Close();
            rd1.Close();
        }
        public  void Searchtheomachuyen()
        {
            int dem1 = 0;
            Console.Write("Nhập mã vé cần tìm: ");
            int NV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
            Console.WriteLine("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã vé"));
            Console.Write(string.Format(" {0, -19} |", "Tên khách hàng "));
            Console.Write(string.Format(" {0, -12} |", "CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Loại KH"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -12} |", "Biển số xe"));
            Console.Write(string.Format(" {0, -12} |", "Số ghế"));
            Console.Write(string.Format(" {0, -12} |", "Giá vé"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.WriteLine(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsvx.Count; i++)
            {
                if (dsvx[i].Mave == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0,8 } |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Mave));
                    Console.Write(string.Format(" {0, -19} |", dsvx[i].Tenkhachhang));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].CMND));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Namsinh));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].LoaiKh));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Machuyen));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Bienso));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Soghe));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Giave));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Noidi));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Noiden));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Ngaydi));
                    Console.WriteLine(string.Format(" {0, -12} |", dsvx[i].Thoigiandi));
                    Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            if (dem1 == 0) Console.WriteLine("                                                                                       ---> không tìm thấy <--- ");
        }
        public void Searchnoiden()
        {
            int dem1 = 0;
            Console.Write("Nhập nơi đến cần tìm: ");
            string NV = Console.ReadLine();
            Console.WriteLine("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
            Console.WriteLine("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.Write(string.Format("{0,8 } |", "STT"));
            Console.Write(string.Format(" {0, -12} |", "Mã vé"));
            Console.Write(string.Format(" {0, -19} |", "Tên khách hàng "));
            Console.Write(string.Format(" {0, -12} |", "CMND"));
            Console.Write(string.Format(" {0, -12} |", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} |", "Loại KH"));
            Console.Write(string.Format(" {0, -12} |", "Mã chuyến"));
            Console.Write(string.Format(" {0, -12} |", "Biển số xe"));
            Console.Write(string.Format(" {0, -12} |", "Số ghế"));
            Console.Write(string.Format(" {0, -12} |", "Giá vé"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đi"));
            Console.Write(string.Format(" {0, -12} |", "Nơi đến"));
            Console.Write(string.Format(" {0, -12} |", "Ngày đi"));
            Console.WriteLine(string.Format(" {0, -12} |", "Thời gian đi"));
            Console.WriteLine("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < dsvx.Count; i++)
            {
                if (dsvx[i].Noiden == NV)
                {
                    dem1++;
                    Console.Write(string.Format("{0,8 } |", i + 1));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Mave));
                    Console.Write(string.Format(" {0, -19} |", dsvx[i].Tenkhachhang));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].CMND));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Namsinh));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].LoaiKh));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Machuyen));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Bienso));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Soghe));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Giave));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Noidi));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Noiden));
                    Console.Write(string.Format(" {0, -12} |", dsvx[i].Ngaydi));
                    Console.WriteLine(string.Format(" {0, -12} |", dsvx[i].Thoigiandi));
                    Console.WriteLine("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            if (dem1 == 0) Console.WriteLine("                                                                                      ---> không tìm thấy <--- ");
        }
        public void ChiXoavexe(int dem,int[] a)
        {
            int flag = 0;
            List<Vexe> tam = dsvx;
            dsvx = new List<Vexe>();
            // Dich chuyen mang
            for (int i = 0; i < tam.Count; i++)
            {
                for (int j = 0; j <= dem; j++)
                {
                    if (i == a[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    dsvx.Add(tam[i]);
                }
                flag = 0;
            }
        }
        public void Xoavexetheomachuyen(int machuyen)
        {
            int dem = 0;
            int[] a = new int[100];
            for (int i = 0; i < dsvx.Count; i++)
            {
                if (dsvx[i].Machuyen == machuyen)
                {
                    a[dem] = i;
                    dem++;
                }
            }
            ChiXoavexe(dem, a);

        }
        public static bool operator >(Vexe a, Vexe b)
        {
            if (a.Machuyen < b.Machuyen) return false;
            return true;
        }
        public static bool operator <(Vexe a, Vexe b)
        {
            if (a.Machuyen > b.Machuyen) return false;
            return true;
        }
        public void Sort()
        {
            Vexe t;
            for (int i = 0; i < dsvx.Count - 1; i++)
            {
                for (int j = i + 1; j < dsvx.Count; j++)
                {
                    if (dsvx[i] > dsvx[j])
                    {
                        t = dsvx[i];
                        dsvx[i] = dsvx[j];
                        dsvx[j] = t;
                    }
                }
            }
            
            GhifileTxt("dsvx.txt");
            dsvx = new List<Vexe>();
        }
    }
}
