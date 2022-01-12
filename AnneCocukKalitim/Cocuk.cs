using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneCocukKalitim
{
    class Cocuk:Anne
    {
        public string cocukAd;
        public Cocuk()
        {
            Console.WriteLine("Çocuk annenin yardımcı kurucusudur.");
        }
        public void CocukKonus()
        {
            Console.WriteLine("Anne lütfen babama söyleme ceza verir bana");
        }

    }
}
