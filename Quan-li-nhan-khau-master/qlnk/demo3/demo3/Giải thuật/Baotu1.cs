using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.Giải_thuật
{
    public class Baotu1
    {
        public string sHovaten;
        public string sNgaymat;
        public string sLidomat;
        public string sNgaykhai;
        public string sNguoikhai;
        public string sGhichu;
        public Baotu1 next = null;
    } 
    public class ListBaotu1
    {
        public Baotu1 pHead;
        public Baotu1 pTail;
        public ListBaotu1()
        {
            pHead = pTail = null;
        }
        public void Addhead(Baotu1 p)
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
        public void Addtail(Baotu1 p)
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
                Baotu1 tam = pHead;
                while (tam.next != pTail) tam = tam.next;
                tam.next = null;
                pTail = tam;
            }
        }
        public void RemoveNode(Baotu1 p,int x)
        { 
            Baotu1 g = new Baotu1();
            Baotu1 k = pHead;
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



