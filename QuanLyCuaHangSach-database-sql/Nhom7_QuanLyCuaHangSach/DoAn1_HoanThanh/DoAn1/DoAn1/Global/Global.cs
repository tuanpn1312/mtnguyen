using DoAn1.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.Global
{
    public class Global
    {
        public static List<SachModel> listHoaDon = new List<SachModel>();

        public static int maChucVu { get; private set; }

        public static void setMaChuc(int ID)
        {
            maChucVu = ID;
        }

        public static int maPhieuNhap { get; private set; }

        public static void setMaPhieuNhap(int ID)
        {
            maPhieuNhap = ID;
        }

        public static string MaSach { get; private set; }

        public static void setMaSach(string maSach)
        {
            MaSach = maSach;
        }

        public static string TenSach { get; private set; }

        public static void setTenSach(string tenSach)
        {
            TenSach = tenSach;
        }

        public static string TacGia { get; private set; }

        public static void setTacGia(string tacGia)
        {
            TacGia = tacGia;
        }

        public static string NXB { get; private set; }

        public static void setNXB(string nXB)
        {
            NXB = nXB;
        }

        public static string MoTa { get; private set; }

        public static void setMoTa(string moTa)
        {
            MoTa = moTa;
        }

        public static string DanhMuc { get; private set; }

        public static void setDanhMuc(string danhMuc)
        {
            DanhMuc = danhMuc;
        }

        public static int SoLuong { get; private set; }

        public static void setSoLuong(int soLuong)
        {
            SoLuong = soLuong;
        }

        public static bool TrangThai { get; private set; }

        public static void setStatus(bool status)
        {
            TrangThai = status;
        }
        public static int Gia { get; private set; }

        public static void setGia(int gia)
        {
            Gia = gia;
        }
    }
}
