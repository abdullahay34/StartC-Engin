using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[]
            {"Yazilim Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java","Python","C++"};

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            // Diziler daha kolay
            // kurs takma isim in class belirtir.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - Footer ");
        }
    }
}
