using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maximum:Numbers
    {  //Creating a list  
        List<int> num = new List<int>();
        public int max;
        public void ReadInput()
        {
            Console.WriteLine("ENTER A THREE NUMBERS");
            Num1=Convert.ToInt32(Console.ReadLine());
            Num2=Convert.ToInt32(Console.ReadLine());
            Num3=Convert.ToInt32(Console.ReadLine());
       
        }
        //MAXIMUM NUMBER FROM 3 INTEGERS
        public void Max()
       
        {     
            num.Add(Num1);
            num.Add(Num2);
            num.Add(Num3);
            Console.WriteLine("NUMBERS ARE: ");
            foreach (int elements in num) 
            {
                Console.WriteLine(elements);
               
            }
              max = num.Max();
            Console.WriteLine("MAXIMUM NUMBER IS:" + max);
           /* if (num[0] == max)
            {
                Console.WriteLine("MAXIMUM NUMBER AT FIRST POSITION:" + num[0]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT FIRST POSITION:" );
            }*/
        }

        public void First_Position()
        {
         
            if (num[0] == max)
            {
                Console.WriteLine("MAXIMUM NUMBER AT FIRST POSITION:" + num[0]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT FIRST POSITION:");
            }

        }


    }

    internal class Numbers
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
    }
}
