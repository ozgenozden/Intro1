using System;

namespace Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "özgen";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Özgür";
            kurs2.KursAdi = "C programlama";
            kurs2.IzlenmeOrani = 86;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Barış";
            kurs3.KursAdi = "Java";
            kurs3.IzlenmeOrani = 57;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : "+kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
