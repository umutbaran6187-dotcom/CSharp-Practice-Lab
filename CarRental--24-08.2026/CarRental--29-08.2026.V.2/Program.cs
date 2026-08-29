using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Arac> arac_listesi = new List<Arac>();
            Arac arac1= new Arac("BMW","M4",1400,true);
            Arac arac2 = new Arac("Mercedes", "CLK", 1800, false);
            Arac arac3 = new Arac("Audi", "A4",2000, true);
            Arac arac4 = new Arac("Volkswagen", "Polo", 500, false);
            arac_listesi.Add(arac1);
            arac_listesi.Add(arac2);
            arac_listesi.Add(arac3);
            arac_listesi.Add(arac4);
            Console.WriteLine("1 - Müsait Araçları Gör | 2 - Kiradaki Araçları Gör");
            int soru1= Convert.ToInt32(Console.ReadLine());
            
            foreach (Arac arc in arac_listesi) {
                if (soru1==1 )
                {
                    if (arc.Kiralikmi==true)
                    {
                        arc.bilgi();
                    }
                }
                if (soru1 == 2)
                {
                    if (arc.Kiralikmi == false)
                    {
                        arc.bilgi();
                    }
                }
            }
        }
        class Arac
        {
            string Marka;
            string Model;
            int gunlukfiyat = 0;
            public bool Kiralikmi;

        
            public Arac(string Arabaninmarkasi,string Arabaninmodeli,int fiyati,bool Musaitmi)
            {
                Marka= Arabaninmarkasi; Model= Arabaninmodeli;gunlukfiyat= fiyati;Kiralikmi = Musaitmi;
            }
            public void bilgi()
            {
  
                
                Console.WriteLine($"Arabanın Markası {Marka}");
                Console.WriteLine($"Arabanın Modeli {Model}");
                Console.WriteLine($"Arabanın Günlük Fiyatı {gunlukfiyat} \n");
                
            }
            


        }
    }
}





