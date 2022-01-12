using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukkan
{
    class Calisan
    {
        public string ad;
        public string soyad;
        public int maas;

        public void CalisanBilgi()
        {
            Console.WriteLine("Çalışanın Adı:"+ad);
            Console.WriteLine("Çalışanın Soyadı:" + soyad);
            Console.WriteLine("Çalışanın Maaşı:" + maas);

        }
    }
}
