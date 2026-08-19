using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon tel1=new Telefon();
            tel1.Marka = "Nokia";
            tel1.oyunoyna(40);
            tel1.Sarjet(20);
            tel1.Durum();
            
        }
        class Telefon
        {
            public string Marka;
            private int sarj = 100;
            public void oyunoyna(int dakika)
            {
                sarj -= (dakika / 10) * 5;
                if (sarj < 0)
                {
                    Console.WriteLine("Telefon Kapanıyor...");
                }
                Console.WriteLine($"{dakika} Dakika dır Oyun oynuyorsunuz.Şarjınız {sarj}");
                if (sarj == 0) {
                    Console.WriteLine("Şarjınız 0 Lütfen şarja takın");
                }
             
        }
            public void Sarjet(int birim)
            {
                sarj+= birim;
                if (sarj >100) {
                    sarj= 100;
            }
                Console.WriteLine($"Şarjınız {sarj}");
    }
            public void Durum()
            {
                Console.WriteLine($"Markanız {Marka} Şarjınız {sarj}");
            }
    }
}
}