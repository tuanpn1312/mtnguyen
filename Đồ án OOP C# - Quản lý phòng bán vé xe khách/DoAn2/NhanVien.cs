using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    public abstract class NhanVien
    {
        protected int iManv;
        protected string sHoten;
        protected int sCMND;
        protected int iNamsinh;
        protected int dNgaycong;
        protected int iLuongcb;
        protected int iLuong;
        //
        public int Manv
        {
            get { return this.iManv; }
            set { this.iManv = value; }
        }
        public string Hoten
        {
            get { return this.sHoten; }
            set { this.sHoten = value; }
        }
        public int CMND
        {
            get { return this.sCMND; }
            set { this.sCMND = value; }
        }
        public int Namsinh
        {
            get { return this.iNamsinh; }
            set { this.iNamsinh = value; }
        }
        public int Ngaycong
        {
            get { return this.dNgaycong; }
            set { this.dNgaycong = value; }
        }
        public int Luongcb
        {
            get { return this.iLuongcb; }
            set { this.iLuongcb = value; }
        }
        public int Luong
        {
            get { return this.iLuong; }
            set { this.iLuong = value; }
        }
        //
        public NhanVien()
        {
           
        }
        public NhanVien(int manv, string hoten, int cmnd, int ngaycong, int namsinh, int luongcoban, int Luong)
        {
            this.Manv = manv;
            this.sHoten = hoten;
            this.sCMND = cmnd;
            this.dNgaycong = ngaycong;
            this.iNamsinh = namsinh;
            this.iLuongcb = luongcoban;
            this.iLuong = Luong;
        }
        public NhanVien(int manv, string hoten, int cmnd, int ngaycong, int namsinh, int luongcoban)
        {
            this.Manv = manv;
            this.sHoten = hoten;
            this.sCMND = cmnd;
            this.dNgaycong = ngaycong;
            this.iNamsinh = namsinh;
            this.iLuongcb = luongcoban;
        }
        public NhanVien(int manv, string hoten, int cmnd, int ngaycong, int namsinh)
        {
            this.iManv = manv;
            this.sHoten = hoten;
            this.sCMND = cmnd;
            this.iNamsinh = namsinh;
            this.dNgaycong = ngaycong;
        }
        public NhanVien(int manv, string hoten, int cmnd, int ngaycong)
        {
            this.iManv = manv;
            this.sHoten = hoten;
            this.sCMND = cmnd;
            this.dNgaycong = ngaycong;
        }
        public NhanVien(int manv, string hoten, int cmnd)
        {
            this.iManv = manv;
            this.sHoten = hoten;
            this.sCMND = cmnd;
        }
        public NhanVien(int manv, string hoten)
        {
            this.iManv = manv;
            this.sHoten = hoten;
        }
        public NhanVien(int manv)
        {
            this.iManv = manv;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma nhan vien: ");
            this.Manv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten nhan vien: ");
            this.sHoten = Console.ReadLine();
            Console.Write("Nhap so cmnd: ");
            this.sCMND = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            this.iNamsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay cong: ");
            this.dNgaycong = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            this.iLuongcb = int.Parse(Console.ReadLine());
        }
        //
        public abstract void Xuat();
        public abstract void GhifileNv(String filename);
        public abstract void DocfileNv(String filename);
        public abstract void Them();
        public abstract void Xoa(int temp);
        public abstract void Sua(int temp);
        public abstract int tinhluong();
        public abstract void sort();    //sắp xếp tăng dần
        public abstract void search();  //tìm kiếm theo tên
        public abstract void luongmax();
        public abstract void luongmin();
        //public abstract void sosanh2();
    }
}
