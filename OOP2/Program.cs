using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1254";
            musteri1.Adi = "Faruk";
            musteri1.Soyadi = "Turan";
            musteri1.TcNo = "123131314";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5494997";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "122321313";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
