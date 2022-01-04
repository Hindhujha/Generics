using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maximum:Numbers
    {  //Creating a list  for integers
     List<int> num = new List<int>();
        public int max;
        public float fmax;
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
        
        }
        //MAXIMUM NUMBER AT FIRST POSITION
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
        //MAXIMUM NUMBER AT SECOND POSITION
        public void Second_Position()
        {

            if (num[1] == max)
            {
                Console.WriteLine("MAXIMUM NUMBER AT SECOND POSITION:" + num[1]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT SECOND POSITION:");
            }

        }
        //MAXIMUM NUMBER AT THIRD POSITION
        public void Third_Position()
        {

            if (num[2] == max)
            {
                Console.WriteLine("MAXIMUM NUMBER AT THIRD POSITION:" + num[2]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT THIRD POSITION:");
            }

        }
        //Creating a list for floating values
        List<float> fnum = new List<float>();

        public void Read_FloatInput()
        {
            Console.WriteLine("ENTER A THREE FLOATING VALUES");
            fNum1 =float.Parse(Console.ReadLine());
            fNum2 = float.Parse(Console.ReadLine());
            fNum3 = float.Parse(Console.ReadLine());

        }
        //MAXIMUM FLOATING VALUES 
        public void fMax()

        {
            fnum.Add(fNum1);
            fnum.Add(fNum2);
            fnum.Add(fNum3);
            Console.WriteLine("FLOATING VALUE NUMBERS ARE: ");
            foreach (float elements in fnum)
            {
                Console.WriteLine(elements);

            }
            fmax = fnum.Max();
            Console.WriteLine("MAXIMUM NUMBER IS:" + fmax);

        }
        //MAXIMUM FLOATING VALUE AT FIRST POSITION
        public void Float_First_Position()
        {

            if (fnum[0] == fmax)
            {
                Console.WriteLine("MAXIMUM NUMBER AT FIRST POSITION:" + fnum[0]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT FIRST POSITION:");
            }

        }
        //MAXIMUM FLOATING VALUE AT SECOND POSITION
        public void Float_Second_Position()
        {

            if (fnum[1] == fmax)
            {
                Console.WriteLine("MAXIMUM NUMBER AT SECOND POSITION:" + fnum[1]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT SECOND POSITION:");
            }

        }



    }

    internal class Numbers
    {
      public int Num1 { get; set; }

      public int Num2 { get; set; }
      public int Num3 { get; set; }
      public float fNum1 { get; set; }
      public float fNum2 { get; set; }
      public float fNum3 { get; set; }

    }
}
