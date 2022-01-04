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
        public string temp;
   
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
        //MAXIMUM FLOATING VALUE AT THIRD POSITION
        public void Float_Third_Position()
        {

            if (fnum[2] == fmax)
            {
                Console.WriteLine("MAXIMUM NUMBER AT SECOND POSITION:" + fnum[2]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT SECOND POSITION:");
            }

        }
        List<string> str = new List<string>();

        public void Read_StringInput()
        {
            Console.WriteLine("ENTER THREE STRINGS");
            Str1 = Console.ReadLine();     
            Str2 = Console.ReadLine();
            Str3 = Console.ReadLine();

        }
        //MAXIMUM CHARACTERS IN STRING  
        public void Strings()

        {
            str.Add(Str1);
            str.Add(Str2);
            str.Add(Str3);
            Console.WriteLine("STRINGS ARE:");
            foreach (string elements in str)
            {
                Console.WriteLine(elements);

            }
          
            int len1 = Str1.Length;
            int len2 = Str2.Length;
            int len3 = Str3.Length;
          if(len1>len2 && len1>len3 )
            {
                Console.WriteLine("MAXIMUM CHARACTERS IN STRING IS:" + Str1);
                temp = Str1;
            }
          else if(len2>len1 && len2>len3)
            {
                Console.WriteLine("MAXIMUM CHARACTERS IN STRING IS:" + Str2);
                temp = Str2;
            }
          else
            {
                Console.WriteLine("MAXIMUM CHARACTERS IN STRING IS:" + Str3);
                temp = Str3;
            }
        }
        //MAXIMUM STRING AT FIRST POSITION
        public void Strings_First_Position()
        {

            if (str[0] == temp)
            {
                Console.WriteLine("MAXIMUM NUMBER AT FIRST POSITION:" + str[0]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT FIRST POSITION:");
            }

        }
        //MAXIMUM STRING SECOND POSITION
        public void Strings_Second_Position()
        {

            if (str[1] == temp)
            {
                Console.WriteLine("MAXIMUM NUMBER AT SECOND POSITION:" + str[1]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT SECOND POSITION:");
            }

        }
        //MAXIMUM STRING SECOND POSITION
        public void Strings_Third_Position()
        {

            if (str[2] == temp)
            {
                Console.WriteLine("MAXIMUM NUMBER AT THIRD POSITION:" + str[2]);
            }
            else
            {

                Console.WriteLine("MAXIMUM NUMBER IS NOT AT THIRD POSITION:");
            }

        }
        //REFACTOR1-FIND MAXIMUM IN ALL VARIABLES
        List<Numbers> type = new List<Numbers>();
        public void Refactor1()
        {
            Maximum maximum = new Maximum();
            maximum.ReadInput();
            maximum.Max();
            maximum.Read_FloatInput();
            maximum.fMax();
            maximum.Read_StringInput();
            maximum.Strings();

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
      public string Str1 { get; set; }
      public string Str2 { get; set; }
      public string Str3 { get; set; }
      
    }
}
