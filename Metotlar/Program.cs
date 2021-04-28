using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar tekrar tekrar kullanmak için - DRY!!
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Ayı";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 8;
            urun3.Aciklama = "Dağ Çileği";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------");
            }

            Console.WriteLine("---Metotlar---");

            //instance - örnek aşağıdaki kot
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Elma", "Yeşil Elma", 10);
            sepetManager.Ekle2("Armut", "Ayi", 10);

            
        }
    }
}
