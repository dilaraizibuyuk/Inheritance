using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();    //temel sınıf değişkenleri
            dog.animal_name = "Kangal";
            dog.animal_gender = "Female";
            dog.animal_color = "Gray";
            dog.animal_age = 2;

            dog.dog_size = 65;  //alt sınıf değişkenleri
            dog.dog_weight = 45;

            dog.animalInfoShow();
            dog.dogMethod();
            Console.ReadLine();
        }
    }
}
