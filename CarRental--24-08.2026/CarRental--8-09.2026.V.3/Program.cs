using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Arac> arac_listesi = new List<Arac>();
            Arac arac1= new Arac(1,"BMW","M4",1400,true);
            Arac arac2 = new Arac(2,"Mercedes", "CLK", 1800, false);
            Arac arac3 = new Arac(3,"Audi", "A4",2000, true);
            Arac arac4 = new Arac(4,"Volkswagen", "Polo", 500, false);
            Arac arac5 = new Arac(5, "Porsche", "911 GT3", 4500, true);
            Arac arac6 = new Arac(6, "Volvo", "XC90", 2200, false);
            Arac arac7 = new Arac(7, "Ford", "Mustang GT", 2800, true);
            Arac arac8 = new Arac(8, "Toyota", "Corolla", 850, true);
            Arac arac9 = new Arac(9, "Tesla", "Model Y", 1900, false);
            Arac arac10 = new Arac(10, "Honda", "Civic", 950, true);
            Arac arac11 = new Arac(11, "BMW", "320i", 1600, false);
            Arac arac12 = new Arac(12, "Renault", "Clio", 600, true);
            Arac arac13 = new Arac(13, "Audi", "RS6", 3800, false);
            Arac arac14 = new Arac(14, "Hyundai", "i20", 650, true);
            arac_listesi.Add(arac1);
            arac_listesi.Add(arac2);
            arac_listesi.Add(arac3);
            arac_listesi.Add(arac4);
            arac_listesi.Add(arac5);
            arac_listesi.Add(arac6);
            arac_listesi.Add(arac7);
            arac_listesi.Add(arac8);
            arac_listesi.Add(arac9);
            arac_listesi.Add(arac10);
            arac_listesi.Add(arac11);
            arac_listesi.Add(arac12);
            arac_listesi.Add(arac13);
            arac_listesi.Add(arac14);
            while (true)
            {
                Console.WriteLine("1 - Müsait Araçları Gör | 2 - Kiradaki Araçları Gör | 3 - Bütün Araçları Gör");
                int soru1 = Convert.ToInt32(Console.ReadLine());
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
                    else if (soru1 == 3)
                {
                   
                        arc.bilgi();
                    
                }
                   
                }
                if  (soru1 == 1) { 
                    Console.WriteLine("Hangi Arabayı kiralamak istersiniz Arabanin idsini giriniz.");
            
            int carid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç gün kiralamak istersiniz.");
            int guns= Convert.ToInt32(Console.ReadLine());
            foreach (Arac arc in arac_listesi)
            {
                if (arc.id == carid)
                {
                    arc.Kirala(guns);
                }
                    }

                }

            }
        }
        class Arac
        {
            string Marka;

            public int id;
            string Model;
            int gunlukfiyat = 0;
            public bool Kiralikmi;

        
            public Arac(int Arabaninidsi, string Arabaninmarkasi,string Arabaninmodeli,int fiyati,bool Musaitmi)
            {
                id = Arabaninidsi; Marka= Arabaninmarkasi; Model= Arabaninmodeli;gunlukfiyat= fiyati;Kiralikmi = Musaitmi;
            }
            public void bilgi()
            {
                if (Kiralikmi == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
            

                }
             
                
                    Console.WriteLine($"Arabanın Id si {id}");
                    Console.WriteLine($"Arabanın Markası {Marka}");
                    Console.WriteLine($"Arabanın Modeli {Model}");
                    Console.WriteLine($"Arabanın Günlük Fiyatı {gunlukfiyat} \n\n");
                Console.ResetColor();

            }
            public void Kirala(int gunsayisi)
            {
               if (Kiralikmi == true)
                {
                    Kiralikmi = false;
                    int ToplamFiyat=gunlukfiyat*gunsayisi;
                    Console.WriteLine($"{Marka} Marka {Model} Model araç {gunsayisi} günlüğüne kiralandı. Toplam Borç: {ToplamFiyat} TL ");
                }
               else
                {
                    Console.WriteLine("Bu araç zaten kiralık");
                    
                }
            }
            

        }
    }
}





