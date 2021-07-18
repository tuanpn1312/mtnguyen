using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2
{
    interface CapnhatDoanhthuvasove
    {
        void Capnhatsaukhixoa(int machuyen, double giave);
        void Suasovedabanvadoanhthu(Ngoaithanh sua, int temp);
        int Searchmachuyen(int machuyen);
        Ngoaithanh ReturnNgoaithanh(int temp);
    }

}
