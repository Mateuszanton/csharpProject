using System;

namespace SecondProject
{
    class ApplicationArchitecture
    {
        //Presentation page 62
        public static void SwitchKalkulator()
        {
            int x;
            int y;
            ApplicationArchitecture klasa = new ApplicationArchitecture();
            Boolean czyKontunuowac = true;
            while (czyKontunuowac)
            {
                Console.WriteLine("Podaj komende: Exit, Add, Sub");
                string komenda = Console.ReadLine();

                if (!(komenda.Equals("Exit") || komenda.Equals("Add") || komenda.Equals("Sub")))
                {
                    Console.WriteLine("bledna komenda");
                    continue;
                }

                switch (komenda)
                {
                    case "Exit":
                        Console.WriteLine("Program zakonczony");
                        czyKontunuowac = false;
                        break;

                    case "Add":
                        x = klasa.pierwszaLiczba();
                        y = klasa.drugaLiczba();
                        Console.WriteLine("suma = {0}", klasa.add(x, y));
                        break;

                    case "Sub":
                        x = klasa.pierwszaLiczba();
                        y = klasa.drugaLiczba();
                        Console.WriteLine("roznica = {0}", klasa.sub(x, y));
                        break;
                }
            }
        }
        public int add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public int sub(int x, int y)
        {
            int sub = x - y;
            return sub;
        }

        public int pierwszaLiczba()
        {
            Console.WriteLine("podaj Pierwsza liczbe");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        public int drugaLiczba()
        {
            try
            {
                Console.WriteLine("podaj Druga liczbe");
            }
            catch (Exception e)
            {
                if (e.Source != null) Console.WriteLine("zjebales");
            }           
            int y = int.Parse(Console.ReadLine());
            return y;
        }
    }
}
