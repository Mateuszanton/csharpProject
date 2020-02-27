using System;
using System.Collections.Generic;
using System.Text;

namespace SecondProject.Exercise_8a
{
    class Validations
    {
        public bool isNumber(String input)
        {
            bool isNumber;
            do
            {
                isNumber = int.TryParse(input, out int correctValue);
                if (!isNumber)
                {
                    Console.WriteLine("Entered value is not a number");
                    return false;
                }
            } while (!isNumber);
            return true;
        }
        public bool isCorrectNumber(String input)
        {
            bool isCorrectNumber;
            do
            {
                isCorrectNumber = input.Length == 9;
                if (!isCorrectNumber)
                {
                    Console.WriteLine("Entered number has wrong number of digits");
                    return false;
                }
            } while (!isCorrectNumber);
            return true;
        }
    }
}
