using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int hours = Convert.ToInt32(Console.ReadLine());
            double forhour = Convert.ToDouble(Console.ReadLine());
            double total_salary = hours * forhour;
            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine($"SALARY = U$ {total_salary}");
        }
    }
}
