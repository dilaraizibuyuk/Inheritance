using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneCocukKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Anne an = new Anne();
            an.ad = "Mina";
            an.soyad = "URGAN";
            
            Cocuk coc = new Cocuk();
            coc.cocukAd = "Zeynep";
            coc.soyad = an.soyad;

            an.Annem();
            Console.WriteLine(an.ad+"\n"+an.soyad);
            an.Selam();
            an.Konus();

            Console.WriteLine(coc.cocukAd+"\n"+coc.soyad);
            coc.CocukKonus();
            Console.ReadLine();
        }
    }
}
