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
                Console.WriteLine("ENTER AN OPTION");
                Console.WriteLine("-----------------");
                Console.WriteLine("1.MAXIMUM VALUE OF 3 INTEGERS");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                       Maximum intmax = new Maximum();
                        intmax.ReadInput();
                       intmax.Max();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT NO:");
                        break;
                }
            }

        }
    }

}

              
