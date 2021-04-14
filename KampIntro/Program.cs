using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double notOrtalaması = 85.84;
            bool sistemeGirisOlmusMu = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");

            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }

            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisOlmusMu == true)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapınız.");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
