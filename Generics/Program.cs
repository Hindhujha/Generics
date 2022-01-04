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
                Console.WriteLine("3.MAXIMUM NUMBER AT SECOND POSITION");
                Console.WriteLine("4.MAXIMUM NUMBER AT THIRD POSITION");
                Console.WriteLine("5.MAXIMUM VALUE OF 3 FLOATING VALUES");
                Console.WriteLine("6.MAXIMUM FLOATING VALUE AT FIRST POSITION");
                Console.WriteLine("7.MAXIMUM FLOATING VALUE AT SECOND POSITION");
                Console.WriteLine("8.MAXIMUM FLOATING VALUE AT THIRD POSITION");
                Console.WriteLine("9.MAXIMUM CHARACTERS IN 3 STRINGS");
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
                    case 3:
                        Maximum intmax2 = new Maximum();
                        intmax2.ReadInput();
                        intmax2.Max();
                        intmax2.Second_Position();
                        break;
                    case 4:
                        Maximum intmax3 = new Maximum();
                        intmax3.ReadInput();
                        intmax3.Max();
                        intmax3.Third_Position();
                        break;
                    case 5:
                        Maximum floatmax = new Maximum();
                        floatmax.Read_FloatInput();
                        floatmax.fMax();
                        break;
                    case 6:
                        Maximum floatmax1 = new Maximum();
                        floatmax1.Read_FloatInput();
                        floatmax1.fMax();
                        floatmax1.Float_First_Position();
                        break;
                    case 7:
                        Maximum floatmax2 = new Maximum();
                        floatmax2.Read_FloatInput();
                        floatmax2.fMax();
                        floatmax2.Float_Second_Position();
                        break;
                    case 8:
                        Maximum floatmax3 = new Maximum();
                        floatmax3.Read_FloatInput();
                        floatmax3.fMax();
                        floatmax3.Float_Third_Position();
                        break;
                    case 9:
                        Maximum strings = new Maximum();
                        strings.Read_StringInput();
                        strings.Strings();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT NO:");
                        break;
                }
            }

        }
    }

}

              
