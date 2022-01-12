using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog:Animal
    {
        public int dog_size;
        public int dog_weight;
        public int dog_height;

        public void dogMethod() {
            Console.WriteLine();
            Console.WriteLine("Dog is barking!!");
            Console.WriteLine("Dog's Size:"+dog_size); 
            Console.WriteLine("Dog's Weight:" + dog_weight);
            Console.WriteLine("Dog's Height:" + dog_height);



        }
    }
}
