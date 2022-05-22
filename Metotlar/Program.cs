using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product prod1 = new Product();
            prod1.Adi = "Elma";
            prod1.Fiyati = 15;
            prod1.Aciklama = "Amasya Elması";

            Product prod2 = new Product();
            prod2.Adi = "Elma";
            prod2.Fiyati = 15;
            prod2.Aciklama = "Amasya Elması";

            Product[] products = new Product[] { prod1, prod2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("*******************************");
            }

            Console.WriteLine("-------------Metotlar----------------");

            SepetManager sepet = new SepetManager();

            sepet.Add(prod1);

        }
    }
}
