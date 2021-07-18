using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.Giải_thuật
{
    public class Nhap_tachkhau1
    {
        public string sHovaten, sSohkht, sSohkdn, sQhe, sNgaynhap;
        public Nhap_tachkhau1 next = null;

    }
    public class ListNhap_tachkhau1
    { 
        public Nhap_tachkhau1 pHead;
        public Nhap_tachkhau1 pTail;
        public ListNhap_tachkhau1()
        {
            pHead = pTail = null;
        }
        public void Addhead(Nhap_tachkhau1 p)
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
        public void Addtail(Nhap_tachkhau1 p)
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
        public void Removehead()
        {
            pHead = pHead.next;
        }
        public void Removetail()
        {
            if (pHead != null)
            {
                if (pHead == pTail)
                {
                    pHead = pTail = null;
                    return;
                }
                Nhap_tachkhau1 tam = pHead;
                while (tam.next != pTail) tam = tam.next;
                tam.next = null;
                pTail = tam;
            }
        }
        public void RemoveNode(Nhap_tachkhau1 p, int x)
        {
            Nhap_tachkhau1 g = new Nhap_tachkhau1();
            Nhap_tachkhau1 k = pHead;
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

    }


}
