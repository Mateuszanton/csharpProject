using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dogs
{
    class Dog: Animal
    {
        public string NameProperty { get; set; }
        public string ColourProperty { get; set; }
        public string BreedProperty { get; set; }
        public bool HungryProperty { get; set; }
        public int AgeProperty { get; set; }

        //public Dog()
        //{
        // default constructor that sets class properties to their default values
        //}

        public Dog()
        {
            NameProperty = "Lassie";
            ColourProperty = "Brown and white";
            BreedProperty = "Collie";
            HungryProperty = true;
            AgeProperty = 2;
        }

        public Dog(string nameParameter, string colourParameter, string breedParameter, bool hungryParameter, int ageParameter)
        {
            NameProperty = nameParameter;
            ColourProperty = colourParameter;
            BreedProperty = breedParameter;
            HungryProperty = hungryParameter;
            AgeProperty = ageParameter;
        }
        public Dog(string nameParameter, string colourParameter, string breedParameter)
        {
            NameProperty = nameParameter;
            ColourProperty = colourParameter;
            BreedProperty = breedParameter;
        }

        public void Bark()
        {
            Console.WriteLine($"{NameProperty} is barking!");
            Console.Beep(5000, 1000);
            Thread.Sleep(1000);
            Console.Beep(5000, 1000);
            Thread.Sleep(1000);
            Console.Beep(5000, 1000);
        }

        string Fetch(string objectToFetch)
        {
            return $"{NameProperty} is fetching the {objectToFetch}!";
        }

        void Fetch(string[] objectToFetch)
        {
            foreach (var element in objectToFetch)
            {
                Console.WriteLine($"{NameProperty} is now fetching the {element}!");
            }
        }

        int GetDogAge()
        {
            return AgeProperty;
        }

        bool IsDogHungry()
        {
            return HungryProperty;
        }

        public void FeedDog()
        {
            HungryProperty = false;
        }

        public void WagTail()
        {
            Console.Clear();
            Console.WriteLine($"{NameProperty} is wagging tail!");
            var spinner = new Spinner(10, 10, 200);

            spinner.Start();
            Thread.Sleep(4000);
            spinner.Stop();
        }        
    }
}
