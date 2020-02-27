using System;
using System.Collections.Generic;
using System.Text;
using SecondProject;

namespace SecondProject.Exercise_8a
{
    class PhoneBookRun
    {
        public static void Main(String[] args)
        {
            //TODO switch dodaj,przeczytaj wszystko, pofiltruj po imieniu,zapisz w pliku, przeczytajplik
            AddNewUser addNewUser = new AddNewUser();
            ReadAllBook readAllBook = new ReadAllBook();
            SaveToFile saveToFile = new SaveToFile();
            ReadFromFile readFromFile = new ReadFromFile();
            PhoneBookOperations operations = new PhoneBookOperations();
            var items = new List<ContactItem>();
            Filter filter = new Filter();

            bool continueLoop = true;

            while (continueLoop)
            {
                Console.WriteLine("enter command Add, readAll, filter, saveToFile, readFromFile, readDatabase End");
                string command = Console.ReadLine().ToUpper();
                switch (command)
                {
                    case "ADD":
                        items.Add(operations.Add());
                        break;
                    case "READALL":
                        operations.readAll();
                        break;
                    case "FILTER":
                        operations.filter(items);
                        break;
                    case "SAVETOFILE":
                        operations.saveToFile(items);
                        break;
                    case "READFROMFILE":
                        operations.readFromFile();
                        break;
                    case "READDATABASE":
                        operations.sqlDataRead();
                        break;
                    case "END":
                        Console.WriteLine("end of the program");
                        continueLoop = false;
                        break;
                    default:
                        Console.WriteLine("\nentered command doesn't exist!\n");
                        break;
                }
            }
        }
    }
}
