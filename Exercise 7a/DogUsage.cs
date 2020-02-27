using System;
using System.Collections.Generic;
using System.Text;
using Dogs;

namespace SecondProject.Exercise_7a
{
    class DogUsage
    {
        public static void dupa(string[] args)
        {
            Dog Piesel = new Dog();
            Dog Lessie = new Dog("Lessie", "Red", "Collie", true, 91);
            Dog Bobik = new Dog("Bobik", "Red", "Ssak", true, 91);

            Piesel.Bark();
            Piesel.WagTail();
            Console.WriteLine(Piesel.NameProperty);

            Console.WriteLine(Lessie.NameProperty + " is hungry: " + Lessie.HungryProperty);
            Lessie.FeedDog();
            Console.WriteLine(Lessie.NameProperty + " is hungry: " + Lessie.HungryProperty);
            Lessie.WagTail();
            Bobik.WagTail();          
        }
    }
}
