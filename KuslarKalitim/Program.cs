using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuslarKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalitim baykus = new Kalitim();
            baykus.Dogal();
            baykus.BaykusTur();
            Console.ReadLine();
        }
    }
    class Cesit
    {
        public Cesit()
        {
            Console.WriteLine("Çok fazla kuş türü vardır!!");
        }
    }

    class Kuslar:Cesit
    {
        public void Dogal()
        {
            Console.WriteLine("Gece yırtıcı kuşları, en çok sevdiğim kuş türüdür!");
        }
    }
    class Kalitim:Kuslar
    {
        public void BaykusTur()
        {
            Console.WriteLine("Baykuşgiller ve peçeli baykuşgiller olmak üzere iki türü vardır!!");
        }
    }
}
