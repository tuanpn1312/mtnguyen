using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo3.Giải_thuật;

namespace demo3.Giải_thuật
{
    public class Nhankhau1
    {
        public string sSosohk, sHovaten, sNgaysinh, sGioitinh, sDantoc, sQuoctich, sCmnd, sNgaycap, sNoicap, sTDhocvan, sNoilamviec;
        public string sNghenghiep, sQuanhe, sTienan;
        public string sNoisinh;
        public string sNguyenquan;
        public string sNoiott;
        public string sChoohientai;
        public string sGhichu;
        public Nhankhau1 next = null;
    }
    public class ListNhankhau1
    { 
            public Nhankhau1 pHead;
            public Nhankhau1 pTail;
            public ListNhankhau1()
            {
                pHead = pTail = null;
            }
            public void Addhead(Nhankhau1 p)
            {
                if (pHead == null)            //list rỗng
                {
                    pHead = p;
                    pTail = p;
                }
                else
                {
                    p.next = pHead;
                    pHead = p;
                }
            }
            public void Addtail(Nhankhau1 p)
            {
                if (pHead == null)            //list rỗng
                {
                    pHead = p;
                    pTail = p;
                }
                else
                {
                    pTail.next = p;
                    pTail = p;
                }
            }
        public void RemoveNode(Nhankhau1 p, int x)
        {
            Nhankhau1 g = new Nhankhau1();
            Nhankhau1 k = pHead;
            int i = 0;
            if (x == 0) pHead = pHead.next;
            else
            {
                while (i < x)
                {
                    g = k;
                    k = k.next;
                    i++;
                }
                g.next = k.next;
            }
        }
        public void DeleteList()
        {
            pHead = pTail = null;
        }
        public ListNhankhau1 SearchSosohk(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sSosohk, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchHovaten(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sHovaten, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchNgaysinh(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sNgaysinh, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchGioitinh(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sGioitinh, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchDantoc(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sDantoc, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchQuoctich(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sQuoctich, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchCMND(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sCmnd, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchNgaycap(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sNgaycap, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchNoicap(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sNoicap, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchTDhocvan(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sTDhocvan, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchNghenghiep(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sNghenghiep, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchQuanhe(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sQuanhe, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }
        public ListNhankhau1 SearchTienan(string x)
        {
            ListNhankhau1 dstam = new ListNhankhau1();
            Nhankhau1 tem = new Nhankhau1();
            int dem = 0;
            for (Nhankhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sTienan, x, true) == 0)
                {
                    tem = p;
                    if (dem == 0)
                    {
                        dstam.Addhead(tem);
                    }
                    else
                    {
                        dstam.Addtail(tem);

                    }
                    dem++;
                }
            }
            tem.next = null;
            return dstam;
        }

    }
}
