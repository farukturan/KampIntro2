using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Futbolcu Yetiştirme Kursu";
            string kurs2 = "Satranç Kursu";
            string kurs3 = "Basketbol Kursu";

            //arrays - diziler

            string[] kurslar = new string[]
            {
                "Futbolcu Yetiştirme Kursu","Satranç Kursu","Basketbol Kursu"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for btti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }

    }
}
