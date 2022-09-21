using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool corectDay = (day == "Saturday" || day == "Sunday" || day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday");
            bool corectFruit = (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes");
            

            if (day== "Saturday" || day== "Sunday")
            {
                if (fruit== "banana")
                {
                    Console.WriteLine($"{ (quantity * 2.70):f2}");
                }
                else if (fruit== "apple")
                {
                    Console.WriteLine($"{ (quantity * 1.25):f2}");
                }
                else if (fruit== "orange")
                {
                    Console.WriteLine($"{ (quantity * 0.90):f2}");
                }
                else if (fruit== "grapefruit")
                {
                    Console.WriteLine($"{ (quantity * 1.60):f2}");
                }
                else if (fruit== "kiwi")
                {
                    Console.WriteLine($"{ (quantity * 3.00):f2}");
                }
                else if (fruit== "pineapple")
                {
                    Console.WriteLine($"{ (quantity * 5.60):f2}");
                }
                else if (fruit== "grapes")
                {
                    Console.WriteLine($"{ (quantity * 4.20):f2}");
                }
            }
            else if (day== "Monday" || day== "Tuesday" || day== "Wednesday" || day== "Thursday" || day== "Friday")
            {
                if(fruit == "banana")
                {
                    Console.WriteLine($"{ (quantity * 2.50):f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{ (quantity * 1.20):f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{ (quantity * 0.85):f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{ (quantity * 1.45):f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{ (quantity * 2.70):f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{ (quantity * 5.50):f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{ (quantity * 3.85):f2}");
                }
            }
            if (!corectDay || !corectFruit)
            {
                Console.WriteLine("error");
            }
        }
    }
}
