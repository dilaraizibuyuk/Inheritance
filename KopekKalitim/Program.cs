using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopekKalitim
{
    public class Canli
    {
        public int ayak;
        public int disSayisi;
        public string tur;

    }

  public class Kopek:Canli
    {
        public void Havla()
        {
            Console.WriteLine("Hav hav hav!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.ayak = 4;
            kopek.disSayisi = 42;
            kopek.tur = "C.Lupus";//kurt

            Console.WriteLine("Köpek Ayak Sayısı:"+kopek.ayak);
            Console.WriteLine("Köpek Diş Sayısı:" + kopek.disSayisi);
            Console.WriteLine("Köpek Türü:" + kopek.tur);
            kopek.Havla();
            Console.ReadLine();
        }
    }
}
