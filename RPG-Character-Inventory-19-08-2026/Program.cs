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
           karakter krt1=new karakter();
            Console.WriteLine("Karakterinizin ismini girin");
            krt1.isim=Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. eşyayı giriniz");
                string kullanicininGirdigiEsya = Console.ReadLine();
                krt1.EsyaAl(kullanicininGirdigiEsya);
            }
            Console.WriteLine("Savaş Başladı");
            krt1.HasarAl(40);
            krt1.IksirKullan();
            krt1.EnvanteriGoster();
        }
        class karakter
        {

            public string isim;
            private int can = 100;
            private int guc = 20;
            private string[] canta = new string[3];
            private int EsyaSayisi = 0;
            public void EsyaAl(string yeniEsya)
            {
                if (EsyaSayisi < canta.Length)
                {
                    canta[EsyaSayisi] = yeniEsya;
                    EsyaSayisi++;
                    Console.WriteLine($"{yeniEsya} çantaya başarıyla koyuldu");
                    
                }
                else
                {
                    Console.WriteLine("Çanta dolu eşya alamazsın");
                }
        }
            public void HasarAl(int darbe)
            {
                can-=darbe;
                if (can <= 0)
                {
                    can = 0;
                    Console.WriteLine("Karakter Bayıldı!");
                }
            }
            public void IksirKullan()
            {
                can +=30;
                if(can > 100)
                {
                    can = 100;
                }
            }
            public void EnvanteriGoster()
            {
                Console.WriteLine($"Karakterin Adı {isim}");
                Console.WriteLine($"Karakterin Canı {can}");
                foreach (var esyalar in canta) {
                    Console.WriteLine($"Eşylar {esyalar}");
                }
            }
    }
}
}
