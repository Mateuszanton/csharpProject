using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace SecondProject.Exercise_8a
{
    class PhoneBookOperations
    {
        public ContactItem Add()
        {
            ContactItem item = new ContactItem();
            Validations validations = new Validations();
            bool isNumber = false;
            bool isValidNumber = false;
            string x;

            Console.Clear();
            Console.WriteLine("Enter the [Name]: ");
            item.name = Console.ReadLine();
            Console.WriteLine("Enter the [Phone Number]: ");
            isNumber = false;
            isValidNumber = false;
            do
            {
                x = Console.ReadLine();
                isNumber = validations.isNumber(x);
                if (isNumber) isValidNumber = validations.isCorrectNumber(x);
            } while (isNumber == false || isValidNumber == false);
            item.phonenum = int.Parse(x);

            Console.WriteLine("Enter the [Street Name]: ");
            item.streetname = Console.ReadLine();
            Console.WriteLine("Enter the [Street Number]: ");
            isNumber = false;
            do
            {
                x = Console.ReadLine();
                isNumber = validations.isNumber(x);
            } while (isNumber == false);
            item.streetnumber = int.Parse(x);
            Console.WriteLine("Enter the [Post Code]: ");
            isNumber = false;
            do
            {
                x = Console.ReadLine();
                isNumber = validations.isNumber(x);
            } while (isNumber == false);
            item.postcode = int.Parse(x);
            Console.WriteLine("Enter the [City Name]");
            item.cityname = Console.ReadLine();
            Console.WriteLine("Enter the [Country Name]");
            item.countryname = Console.ReadLine();
            Console.WriteLine("Enter the [Gender]");
            item.gender = Console.ReadLine();
            return item;
        }
        public void readAll()
        {
            foreach (ContactItem element in UserContactsList.contactList)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(element))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(element);
                    Console.WriteLine("{0} = {1}", name, value);
                }
            }
        }
        public void filter(List<ContactItem> list)
        {
            Console.Clear();
            Console.WriteLine("Enter the Name of contact which you want to show: ");
            string findName = Console.ReadLine();

            var result = list.FindAll(x => x.name.Contains(findName));

            foreach (ContactItem item in result)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(item);
                    Console.WriteLine("{0} = {1}", name, value);
                }
            }
        }
        public void saveToFile(List<ContactItem> list)
        {
            Console.Clear();

            try
            {
                using (StreamWriter file = new StreamWriter(@"Z:\Upskill\C# upskill\SecondProject\workFolder\WriteLines.txt"))
                    foreach (ContactItem element in list)
                    {
                        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(element))
                        {
                            string name = descriptor.Name;
                            object value = descriptor.GetValue(element);
                            file.WriteLine("{0} = {1}", name, value);
                        }
                    }
                Console.WriteLine("file saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("file not saved");
            }
        }
        public void readFromFile()
        {
            Console.Clear();
            string line = "";
            using (StreamReader sr = new StreamReader(@"Z:\Upskill\C# upskill\SecondProject\workFolder\WriteLines.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public void sqlDataRead()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=PLMANTON\SQLEXPRESS;Initial Catalog=TSQL2012;Integrated Security=True");
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from top3ProblematicThreads", sqlCon);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                Console.WriteLine(row["threadName"]);
            }
        }
    }
}
