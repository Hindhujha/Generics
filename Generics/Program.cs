using System;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIND MAXIMUM PROBLEMS USING GENERICS");
            while (true)
            {
               
                Console.WriteLine("-----------------");
                Console.WriteLine("1.MAXIMUM VALUE OF 3 INTEGERS");
                Console.WriteLine("2.MAXIMUM NUMBER AT FIRST POSITION");
                Console.WriteLine("ENTER AN OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                       Maximum intmax = new Maximum();
                        intmax.ReadInput();
                       intmax.Max();
                        break;
                   case 2:
                        Maximum intmax1 = new Maximum();
                        intmax1.ReadInput();
                        intmax1.Max();
                        intmax1.First_Position();
                        break;   
                    default:
                        Console.WriteLine("ENTER A CORRECT NO:");
                        break;
                }
            }

        }
    }

}

              
