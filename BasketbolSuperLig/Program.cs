using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbolSuperLig
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Basketbolcu KOBE = new Basketbolcu();
            KOBE.ULKE = "Amerika";
            KOBE.LİG = "NBA";
            KOBE.TAKİM = "Los Angeles Lakers";
            KOBE.AD = "Kobe";
            KOBE.SOYAD = "Bryant";
            KOBE.POZİSYON = "Şutör gard"; //kısa forvet
            KOBE.YASİ = 41;

            Console.WriteLine("Ad:" + KOBE.AD);
            Console.WriteLine("Soyad:" + KOBE.SOYAD);

            Console.WriteLine("Yaşı:" + KOBE.YASİ);
            Console.WriteLine("Ülke:" + KOBE.ULKE);
            Console.WriteLine("Lig:" + KOBE.LİG);
            Console.WriteLine("Pozisyon:" + KOBE.POZİSYON);

            Console.ReadLine();

        }
    }
}
