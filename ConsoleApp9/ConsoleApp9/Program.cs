using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string menu = Console.ReadLine();
            int breakfaseset = 5;
            int weekendset = 2;
            int coffee = 3;
            int a=1;
            for (bool i =true;i!=false;a++)
            {
                menu = Console.ReadLine();
                if (menu == "Breakfast Set")
                {
                    breakfaseset = breakfaseset - 1;
                    if (breakfaseset < 1)
                    {
                        Console.WriteLine("Sorry your order is out stock");
                    }
                    else if (time > 11)
                    {
                        Console.WriteLine("Sorry your order is note available");
                    }
                }
                else if (menu == "Weekend Set")
                {
                    weekendset = weekendset - 1;
                    if (weekendset < 1)
                    {
                        Console.WriteLine("Sorry your order is out stock");
                    }
                    else if (day >= 1 && day <= 5)
                    {
                        Console.WriteLine("Sorry your order is note available");
                    }
                }
                else if (menu == "Coffee")
                {
                    coffee = coffee - 1;
                    if (coffee < 1)
                    {
                        Console.WriteLine("Sorry your order is out stock");
                    }
                }
                else if (menu == "End")
                {
                    i = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }

            }


        }
        
            
        
    }
}
