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
        public int x, y, z,p,q,r;
        //find maximum value by using parametreized constructor
        public void Refactor2(int a,int b,int c,int d,int e,int f)

        {  
            type.Add(a);
            type.Add(b);
            type.Add(c);
            type.Add(d);
            type.Add(e);
            type.Add(f);
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
            Console.WriteLine("ENTER A 6 NUMBERS");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z= Convert.ToInt32(Console.ReadLine());
            //more than 3 parameters
            p= Convert.ToInt32(Console.ReadLine());
            q= Convert.ToInt32(Console.ReadLine());
            r= Convert.ToInt32(Console.ReadLine());
            Generic_Class obj = new Generic_Class();
            obj.Refactor2(x,y,z,p,q,r);
        }
        //Internally called from Refactor2 method
        public void PrintMax()
        {
            Generic_Class obj1 = new Generic_Class();
            obj1.call();
        }
    }
}
