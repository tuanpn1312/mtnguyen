using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.Giải_thuật
{
    public class Tamtru_tamvang1
    {
        public string sHovaten, sNgayvang, sVangdenngay, sLido;
        public string sNguoikhaibao, sGhichu, sNgaylap;
        public Tamtru_tamvang1 next = null;

    }
    public class ListTamtru_tamvang1
    { 
        public Tamtru_tamvang1 pHead;
        public Tamtru_tamvang1 pTail;
        public ListTamtru_tamvang1()
        {
            pHead = pTail = null;
        }
        public void Addhead(Tamtru_tamvang1 p)
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
        public void Addtail(Tamtru_tamvang1 p)
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
                Tamtru_tamvang1 tam = pHead;
                while (tam.next != pTail) tam = tam.next;
                tam.next = null;
                pTail = tam;
            }
        }
        public void RemoveNode(Tamtru_tamvang1 p, int x)
        {
            Tamtru_tamvang1 g = new Tamtru_tamvang1();
            Tamtru_tamvang1 k = pHead;
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
