using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);

        }

        public void Ekle2(string productAdi,string productAciklama,double productFiyati,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + productAdi);
        }
    }
}
