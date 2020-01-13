using System;

namespace App2
{
    class task2
    {
        static void Main(string[] args)
        {    
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int greatest = 0;
            if(num1 > num2 && num1 > num3)
            {
                greatest = num1;
                Console.WriteLine($"{greatest} eh o maior");
            }
            else if(num2 >num1 && num2>num3)
            {
                greatest = num2;
                Console.WriteLine($"{greatest} eh o maior");
            }
            else
            {
                greatest = num3;
                Console.WriteLine($"{greatest} eh o maior");
            }        
        }
        
    }
}
