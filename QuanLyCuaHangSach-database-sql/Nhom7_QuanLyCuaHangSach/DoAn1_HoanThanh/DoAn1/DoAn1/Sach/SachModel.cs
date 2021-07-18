using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.Sach
{
    public class SachModel
    {
        private string MaSach;
        private string TenSach;
        private string TacGia;
        private string NXB;
        private string MoTa;
        private string DanhMuc;
        private int SoLuongTon;
        private int Gia;

        public SachModel()
        {

        }

        public SachModel(string MaSach, string TenSach, int SoLuongTon, int Gia)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.SoLuongTon = SoLuongTon;
            this.Gia = Gia;
        }

        public SachModel(string MaSach, string TenSach, string TacGia, string NXB, string MoTa, string DanhMuc, int SoLuongTon, int Gia)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.TacGia = TacGia;
            this.NXB = NXB;
            this.MoTa = MoTa;
            this.DanhMuc = DanhMuc;
            this.SoLuongTon = SoLuongTon;
            this.Gia = Gia;
        }

        public string maSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }

        public string tenSach
        {
            get { return TenSach; }
            set { TenSach = value; }
        }

        public string tacGia
        {
            get { return TacGia; }
            set { TacGia = value; }
        }

        public string nXB
        {
            get { return NXB; }
            set { NXB = value; }
        }

        public string moTa
        {
            get { return MoTa; }
            set { MoTa = value; }
        }

        public string danhMuc
        {
            get { return DanhMuc; }
            set { DanhMuc = value; }
        }

        public int soLuongTon
        {
            get { return SoLuongTon; }
            set { SoLuongTon = value; }
        }

        public int gia
        {
            get { return Gia; }
            set { Gia = value; }
        }
    }
}
