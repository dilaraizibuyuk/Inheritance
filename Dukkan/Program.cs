using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukkan
{
    class Program
    {
        static void Main(string[] args)
        {
            Satis st = new Satis();
            st.ad = "Dilara";
            st.soyad = "İzibüyük";
            st.maas = 15000;
            st.satismiktari = 1700;
            st.satis();
            st.CalisanBilgi();

            Console.ReadLine();
        }
        
    }
}
