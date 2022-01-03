using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maximum:Numbers
    {
        public void ReadInput()
        {
            Console.WriteLine("ENTER A THREE NUMBERS");
            Num1=Convert.ToInt32(Console.ReadLine());
            Num2=Convert.ToInt32(Console.ReadLine());
            Num3=Convert.ToInt32(Console.ReadLine());
        }
        public void Max()
        {
            
           
            List<int> num = new List<int>();

           
            num.Add(Num1);
            num.Add(Num2);
            num.Add(Num3);
            Console.WriteLine("NUMBERS ARE: ");
            foreach (int elements in num) 
            {
                Console.WriteLine(elements);
            }
            int max = num.Max();
            Console.WriteLine("MAXIMUM NUMBER IS:" + max);
        }
    }

    internal class Numbers
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
    }
}
