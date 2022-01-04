using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generic_Class:Numbers
    {
        public List<int> type = new List<int>();
        public int typemax;
        public int x, y, z;
        public void Refactor2(int a,int b,int c)

        {  
            type.Add(a);
            type.Add(b);
            type.Add(c);
            Console.WriteLine("NUMBERS ARE: ");
            foreach (int elements in type)
            {
                Console.WriteLine(elements);

            }
            typemax = type.Max();
            Console.WriteLine("MAXIMUM NUMBER IS:" + typemax);

        }
        public void call()
        {
            Console.WriteLine("ENTER A NUMBERS");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z= Convert.ToInt32(Console.ReadLine());
            Generic_Class obj = new Generic_Class();
            obj.Refactor2(x,y,z);
        }
    }
}
