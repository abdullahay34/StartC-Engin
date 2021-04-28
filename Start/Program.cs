using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Safety - Tip Güvenliği

            // Don't Repat Yoursel DRY

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani=1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);





        }
    }
}
