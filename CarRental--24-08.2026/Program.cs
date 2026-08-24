using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac arac1= new Arac("BMW","M4",1400,true);
            arac1.bilgi();
            Arac arac2 = new Arac("Mercedes", "CLK", 1800, false);
            arac2.bilgi();
            Arac arac3 = new Arac("Audi", "A4",2000, true);
            arac3.bilgi();
            Arac arac4 = new Arac("Wolkswagen", "Polo", 500, false);
            arac4.bilgi();
        }
        class Arac
        {
            string Marka;
            string Model;
            int gunlukfiyat = 0;
            bool Kiralikmi;
            public Arac(string Arabaninmarkasi,string Arabaninmodeli,int fiyati,bool Musaitmi)
            {
                Marka= Arabaninmarkasi; Model= Arabaninmodeli;gunlukfiyat= fiyati;Kiralikmi = Musaitmi;
            }

            public void bilgi()
            {
                if (Kiralikmi == true)
                {
                Console.WriteLine($"Arabanın Markası {Marka}");
                Console.WriteLine($"Arabanın Modeli {Model}");
                Console.WriteLine($"Arabanın Günlük Fiyatı {gunlukfiyat} \n");
            }

        }



        }
    }
}
