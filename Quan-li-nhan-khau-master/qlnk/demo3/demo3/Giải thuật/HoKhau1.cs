using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo3.Giải_thuật;

namespace demo3.Giải_thuật
{
    public class HoKhau1
    {
        public string sSosohk, sHovatenchuho, sGioitinh, sDantoc, sQuoctich, sCMND;
        public string sChoohientai;
        public string sNgaysinh, sNgaydangky;
        public HoKhau1 next = null;
    }
    public class ListHoKhau1
    {
        public HoKhau1 pHead;
        public HoKhau1 pTail;
        public ListHoKhau1()
        {
            pHead = pTail = null;       //khởi tạo
        }
        public void Addhead(HoKhau1 p)
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
        public void Addtail(HoKhau1 p)
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
        public void RemoveNode(HoKhau1 p, int x)
        {
            HoKhau1 g = new HoKhau1();
            HoKhau1 k = pHead;
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
            pHead = pTail= null;
        }
        public ListHoKhau1 SearchSosohk(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
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
        public ListHoKhau1 SearchHovatenchuho(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
            {
                if(string.Compare(p.sHovatenchuho,x,true)==0)
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
        public ListHoKhau1 SearchCMND(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sCMND, x, true) == 0)
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
        public ListHoKhau1 SearchGioitinh(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
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
        public ListHoKhau1 SearchNgaysinh(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
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
        public ListHoKhau1 SearchDantoc(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
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
        public ListHoKhau1 SearchQuoctich(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
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
        public ListHoKhau1 SearchNgaydangky(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sNgaydangky, x, true) == 0)
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
        public ListHoKhau1 SearchChoohientai(string x)
        {
            ListHoKhau1 dstam = new ListHoKhau1();
            HoKhau1 tem = new HoKhau1();
            int dem = 0;
            for (HoKhau1 p = pHead; p != null; p = p.next)
            {
                if (string.Compare(p.sChoohientai, x, true) == 0)
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
