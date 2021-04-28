using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.IzlenmeOrani = 55;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.KursunEgitmeni = "Cengiz";
            kurs2.IzlenmeOrani = 15;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.KursunEgitmeni = "Murat";
            kurs3.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni + " : " + kurs.IzlenmeOrani);
             }


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
