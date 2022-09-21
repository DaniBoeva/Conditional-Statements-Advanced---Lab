using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool corectTown = (town == "Sofia" || town == "Varna" || town == "Plovdiv");
            bool corectSales = sales >= 0;

            if (town== "Sofia")
            {
                if (sales>=0 && sales<=500)
                {
                    double comision = sales * 0.05;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales>500 && sales<=1000)
                {
                    double comision = sales * 0.07;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales>1000 && sales<=10000)
                {
                    double comision = sales * 0.08;
                    Console.WriteLine($"{comision:f2}");
                }
                else if(sales>10000)
                {
                    double comision = sales * 0.12;
                    Console.WriteLine($"{comision:f2}");
                }
            }
            else if (town== "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    double comision = sales * 0.045;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    double comision = sales * 0.075;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    double comision = sales * 0.10;
                    Console.WriteLine($"{comision:f2}");
                }
                else if(sales > 10000)
                {
                    double comision = sales * 0.13;
                    Console.WriteLine($"{comision:f2}");
                }
            }
            else if (town== "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    double comision = sales * 0.055;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    double comision = sales * 0.08;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    double comision = sales * 0.12;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (sales > 10000)
                {
                    double comision = sales * 0.145;
                    Console.WriteLine($"{comision:f2}");
                }
            }
            if (!corectTown || !corectSales )
            {
                Console.WriteLine("error");
            }
        }
    }
}
