using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.Giải_thuật
{
    public class Dienbien1
    {
        public string sHovaten, sNoidi, sNgaydi, sNoiden;
        public string sNgayden, sLido, sNgaylap;
        public Dienbien1 next = null;

    }
    public class ListDienbien1
    { 
        public Dienbien1 pHead;
        public Dienbien1 pTail;
        public ListDienbien1()
        {
            pHead = pTail = null;
        }
        public void Addhead(Dienbien1 p)
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
        public void Addtail(Dienbien1 p)
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
                Dienbien1 tam = pHead;
                while (tam.next != pTail) tam = tam.next;
                tam.next = null;
                pTail = tam;
            }
        }
        public void RemoveNode(Dienbien1 p, int x)
        {
            Dienbien1 g = new Dienbien1();
            Dienbien1 k = pHead;
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


    
