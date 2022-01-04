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
                Console.WriteLine("10.MAXIMUM CHARACTERS IN STRING AT FIRST POSITION");
                Console.WriteLine("11.MAXIMUM CHARACTERS IN STRING AT SECOND POSITION");
                Console.WriteLine("12.MAXIMUM CHARACTERS IN STRING AT THIRD POSITION");
                Console.WriteLine("13.REFACTOR ALL IN ONE GENERIC METHOD");
                Console.WriteLine("14.REFACTOR IN GENERIC CLASS");
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
                    case 10:
                        Maximum strings1 = new Maximum();
                        strings1.Read_StringInput();
                        strings1.Strings();
                        strings1.Strings_First_Position();
                        break;
                    case 11:
                        Maximum strings2 = new Maximum();
                        strings2.Read_StringInput();
                        strings2.Strings();
                        strings2.Strings_Second_Position();
                        break;
                    case 12:
                        Maximum strings3 = new Maximum();
                        strings3.Read_StringInput();
                        strings3.Strings();
                        strings3.Strings_Third_Position();
                        break;
                    case 13:
                        Maximum maximum=new Maximum();
                        maximum.Refactor1();
                        break;
                    case 14:
                        Generic_Class obj = new Generic_Class();
                        obj.call();
                        break;
                    case 15:
                        Generic_Class obj1 = new Generic_Class();
                        obj1.call();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT NO:");
                        break;
                }
            }

        }
    }

}

              
