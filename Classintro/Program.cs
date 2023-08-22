using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "engin demiroğ";
            kurs2.IzlenmeOrani = 68;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "engin demiroğ";
            kurs3.IzlenmeOrani = 68;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen+" : "+kurs.IzlenmeOrani); 
            }

            bool transferDurumu = true;
            string mesaj = transferDurumu == true ? "talisca geliyor" : "onana geliyor";
            Console.WriteLine (mesaj);

            Console.WriteLine("Lütfen trafik lambası rengini giriniz");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "kırmızı": Console.WriteLine("Dur"); break;
                case "sarı": Console.WriteLine("Hazır Ol"); break;
                case "yeşil": Console.WriteLine("İlerle"); break;

                default: Console.WriteLine("Böyle bir trafik rengi yok"); break;
            }

            Console.ReadLine();
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }

    
}
