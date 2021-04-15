using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "faruk", "fatih", "furkan" };


            List<string> isimler2 = new List<string> {"faruk","fatih","furkan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("ali");
            Console.WriteLine(isimler2[3]);

        }
    }
}
