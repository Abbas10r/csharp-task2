using System;

namespace App2
{
    class task3
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double total = 0;
            switch(x)
            {
                case 1:
                    total = 4.00 * y;
                    Console.WriteLine($"Total: R$ {total} ");                
                    break;
                case 2:
                    total = 4.50 * y;
                    Console.WriteLine($"Total: R$ {total} ");
                    break;
                case 3:
                    total = 5.00 * y;
                    Console.WriteLine($"Total: R$ {total} ");
                    break;
                case 4:
                    total = 2.00 * y;
                    Console.WriteLine($"Total: R$ {total} ");
                    break;
                case 5:
                    total = 1.50 *y;
                    Console.WriteLine($"Total: R$ {total} ");
                    break;
            }            
        }
    }
}
