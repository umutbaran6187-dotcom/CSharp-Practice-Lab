using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klima klima = new Klima("Klima1", false, 1.34);
            Klima klima2 = new Klima("Klima2", true, 1.34);
            RobotSupurge rbt1 = new RobotSupurge("RobotSüpürge", true, 2.0);
            List<AkilliCihaz> Cihazlar = new List<AkilliCihaz>();
            Cihazlar.Add(klima);
            Cihazlar.Add(klima2);
            Cihazlar.Add(rbt1);
            klima2.SicaklikAyarla(23);
            rbt1.Ultrahizli();
            rbt1.SarjEt();

            foreach (AkilliCihaz cihazlar in Cihazlar) {
                cihazlar.Calis();

            }
            var Acikcihazlar = Cihazlar.Where(c => c.acikMi).ToList();
            foreach (AkilliCihaz cihaz in Acikcihazlar)
            {
                Console.WriteLine(cihaz.cihazAdi);
            }
            double HedeflenenEnerji = Cihazlar.Sum(t => t.saatlikTuketim);
            Console.WriteLine($"Bütün cihazların toplam tüketimi{HedeflenenEnerji}");
            var acikCihazlarTuketim = Cihazlar.Where(t => t.acikMi).Sum(t => t.saatlikTuketim);
            Console.WriteLine($"Açık cihazların toplam tüketimi{acikCihazlarTuketim}");
            var sicaklikayarlan=Cihazlar.OfType<ISicaklikAyarlanabilir>().ToList();
            foreach(AkilliCihaz sicaklik in sicaklikayarlan)
            {
                Console.WriteLine($"Sıcaklığı ayarlanabilen cihazlar {sicaklik.cihazAdi}");
            }
        }
        abstract class AkilliCihaz
        {
            public string cihazAdi;
            public bool acikMi { get; protected set; }
            public double saatlikTuketim;
            public AkilliCihaz(string cihazAdi, bool acikMi,double saatlikTuketim)
            {
                this.cihazAdi = cihazAdi;
                this.acikMi = acikMi;
                this.saatlikTuketim = saatlikTuketim;
            }
            public virtual void Ac()
            {
                acikMi= true;
                Console.WriteLine("Cihaz Açık");
            }
            public virtual void Kapat()
            {
                acikMi= false;
                Console.WriteLine("Cihaz Kapalı");
            }
            public abstract void Calis();
        }
        interface ISicaklikAyarlanabilir
        {
            void SicaklikAyarla(int YeniSicaklik);
        }
        class Klima:AkilliCihaz,ISicaklikAyarlanabilir
        {
            private int sicaklik=20;
            public Klima(string klimaAdi, bool klimaAcikmi ,double klimaTuketim)
     :base(klimaAdi,klimaAcikmi, klimaTuketim)
            {
                
            }
          
            public override void Calis()
            {
                if (acikMi == true) {
                    Console.WriteLine($"Cihaz Açık.Cihaz Adı {cihazAdi} Tüketim {saatlikTuketim}Kw  Sıcaklık {sicaklik}");
                }
                else
                {
                    Console.WriteLine("Cihaz Kapalı Olduğu İçin Çalışmıyor");

                }

            }
            public void SicaklikAyarla(int YeniSicaklik)
            {
               sicaklik= YeniSicaklik;
                Console.WriteLine($"{cihazAdi} Yeni sıcaklık {sicaklik} ayarlandı");

            }
           
         

        }
        class RobotSupurge : AkilliCihaz,ISarjEdilebilir
        {
            int sarj = 100;
            public RobotSupurge(string supurgeAdi, bool supurgeAcikmi, double supurgeTuketim)
     : base(supurgeAdi, supurgeAcikmi, supurgeTuketim)
            {

            }
            public override void Calis()
            {
               
                if (acikMi == true) {
                    if (sarj >= 20)
                    {
                        Console.WriteLine($"{cihazAdi} çalışıyor.");
                        sarj -= 20;
                    }
                    else
                    {
                        Console.WriteLine("Şarj yok lütfen cihazı şarj ediniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Cihaz Kapalı Olduğu İçin Çalışmıyor");

                }
            }
            public void Ultrahizli()
            {
                if (acikMi && sarj >= 50)
                {

                    Console.WriteLine("Ultra hızlı süpürme işlemi başladı.");
                    sarj -= 50;
                }
                else
                {
                    if(sarj <50 && !acikMi)
                    {
                        Console.WriteLine("Şarjınız yetmiyor,Cihazınız açık değil lütfen cihazı açınız.");
                    }
                    else if (sarj<50) { Console.WriteLine("Şarjınız yetmiyor."); }
                    else if (!acikMi) { Console.WriteLine("Cihazınız açık değil lütfen cihazı açınız."); }
                }
                
        }
        public void SarjEt() {
                if (sarj < 100)
                {
                    sarj = 100;
                    Console.WriteLine("Şarjınız doldu.");
                }
                else
                {
                    Console.WriteLine("Şarjınız dolu");
                }
            }

    }
        interface ISarjEdilebilir
        {
            void SarjEt();
        }
    }
}
