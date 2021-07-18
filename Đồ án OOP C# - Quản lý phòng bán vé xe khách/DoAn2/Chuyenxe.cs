using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    public abstract class Chuyenxe
    {
        protected int iMaso;
        protected string sTentaixe;
        protected string sBienso;
        protected double iDoanhthu;
        protected double iGiave;
        protected int iSove;
        //
        public int Maso
        {
            get { return this.iMaso; }
            set { this.iMaso = value; }
        }
        public string Tentaixe
        {
            get { return this.sTentaixe; }
            set { this.sTentaixe = value; }
        }
        public string Bienso
        {
            get { return this.sBienso; }
            set { this.sBienso = value; }
        }
        public double Doanhthu
        {
            get { return this.iDoanhthu; }
            set { this.iDoanhthu = value; }
        }
        public double Giave
        {
            get { return this.iGiave; }
            set { this.iGiave = value; }
        }
        public int Sove
        {
            get { return this.iSove; }
            set { this.iSove = value; }
        }
        //
        public Chuyenxe()
        {

        }
        /* public Chuyenxe(int Maso, string Tentaixe, string Bienso, int Doanhthu, int Sovedaban, int Giave)
         {
             this.iMaso = Maso;
             this.sTentaixe = Tentaixe;
             this.sBienso = Bienso;
             this.iDoanhthu = Doanhthu;
             this.iSovedaban = Sovedaban;
             this.iGiave = Giave;
         }
         public Chuyenxe(int Maso, string Tentaixe, string Bienso, int Doanhthu, int Sovedaban)
         {
             this.iMaso = Maso;
             this.sTentaixe = Tentaixe;
             this.sBienso = Bienso;
             this.iDoanhthu = Doanhthu;
             this.iSovedaban = Sovedaban;
         }
         public Chuyenxe(int Maso, string Tentaixe, string Bienso, int Doanhthu)
         {
             this.iMaso = Maso;
             this.sTentaixe = Tentaixe;
             this.sBienso = Bienso;
             this.iDoanhthu = Doanhthu;
         }
         public Chuyenxe(int Maso, string Tentaixe, string Bienso)
         {
             this.iMaso = Maso;
             this.sTentaixe = Tentaixe;
             this.sBienso = Bienso;
         }
         public Chuyenxe(int Maso, string Tentaixe)
         {
             this.iMaso = Maso;
             this.sTentaixe = Tentaixe;
         }
         public Chuyenxe(int Maso)
         {
             this.iMaso = Maso;
         }*/
        //
        public void Nhap()
        {
            Console.Write("Nhập mã số tuyến : ");
            this.iMaso = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên tài xế: ");
            this.sTentaixe = Console.ReadLine();
            Console.Write("Nhập biển số: ");
            this.sBienso = Console.ReadLine();
            Console.Write("Nhập giá vé: ");
            this.iGiave = double.Parse(Console.ReadLine());
            Console.Write("Nhập số vé: ");
            this.iSove = int.Parse(Console.ReadLine());
            // Console.Write("Nhập doanh thu: ");
            //this.iDoanhthu = Convert.ToInt32(Console.ReadLine());
        }
        public abstract void Xuat();
        public abstract void GhifileTxt(string filename);
        public abstract void DocfileTxt(string filename);
        public abstract double Tinhdoanhthu();
        public abstract void Them();
        public abstract void Sua(int temp);
        public abstract void Xoa(int temp);
        public abstract void Sort();
        public abstract void Search();
        public abstract void chuyenmax();
        public abstract void chuyenmin();

    }
}
