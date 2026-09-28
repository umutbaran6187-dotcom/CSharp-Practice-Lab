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
            List<BankaHesabi> BankaHesablari = new List<BankaHesabi>();
            BankaHesabi hesap1 = new BankaHesabi(2343545,"Umut Baran",3424);
            BankaHesabi hesap2 = new BankaHesabi(111, "Ali Veli", 500);
            BankaHesabi hesap3 = new BankaHesabi(1001, "Ahmet Yılmaz", 12500.50m);
            BankaHesabi hesap4 = new BankaHesabi(1002, "Zeynep Kaya", 450.00m);
            BankaHesabi hesap5 = new BankaHesabi(1003, "Mehmet Demir", 87200.75m);
            BankaHesabi hesap6 = new BankaHesabi(1004, "Elif Çelik", 3100.00m);
            BankaHesabi hesap7 = new BankaHesabi(1005, "Burak Şahin", 50.25m);
            BankaHesablari.Add(hesap1);
            BankaHesablari.Add(hesap2);
            BankaHesablari.Add(hesap3);
            BankaHesablari.Add(hesap4);
            BankaHesablari.Add(hesap5);
            BankaHesablari.Add(hesap6);
            BankaHesablari.Add(hesap7);
            while (true)
            {
             
                Console.WriteLine($"Hesab Nonuz nedir?");
                int girilenHesapNo=Convert.ToInt32(Console.ReadLine());
                foreach(BankaHesabi hesap in BankaHesablari)

                {
                    while (hesap.Bakiye>=0) { 
                    if (hesap.HesapNo == girilenHesapNo) {
                        Console.WriteLine($"Hoşgeldiniz {hesap.HesapSahibi} ,ne işlemi yapmak istersiniz?");
                      Console.WriteLine("|1| ParaYatir || |2| ParaCek || |3| Hesap Bilgileri |4| Çıkış Yap");
                        int girdi=Convert.ToInt32(Console.ReadLine());
                            if (girdi == 1)
                            {
                                Console.WriteLine("Kaç Para Yatırmak İstersiniz?");
                                int para = Convert.ToInt32(Console.ReadLine());
                                hesap.ParaYatir(miktar: para);
                                Console.WriteLine($"Başarıyla işlem gerçekleşti.Hesabınızda {hesap.Bakiye} para var.");

                            }
                            else if (girdi == 2)
                            {
                                Console.WriteLine("Kaç Para Çekmek İstersiniz?");
                                int para = Convert.ToInt32(Console.ReadLine());
                                if (hesap.ParaCek(para))
                                {
                                    Console.WriteLine($"Başarıyla işlem gerçekleşti. Hesabınızda {hesap.Bakiye} para kaldı.");
                                }
                                
                       
                        }
                        else if (girdi == 3)
                        {
                            hesap.Hesabilgisi();
                         
                        }
                            else if (girdi == 4)
                            {
                                Console.WriteLine("Çıkış Yapılıyor!!");
                                return;
                            }
                            else
                        {

                            Console.WriteLine("Yanlış Tuşlama Yaptınız.");
                                break;


                            }



                        }

                        else
                        {
                            Console.WriteLine("Böyle bir hesap bulunmamaktadır.Lütfen tekrar deneyiniz..");
                            break;
                        }

                    }
               

            }
        }
        }
        class BankaHesabi
        {
            public int HesapNo;
            public int GirilenHesapNo;
            public string HesapSahibi;
            public decimal Bakiye;       
        public BankaHesabi(int Hesabinnosu,string Hesabinsahibii,decimal hesabınbakiyesi)
            {
                HesapNo= Hesabinnosu;HesapSahibi= Hesabinsahibii;Bakiye = hesabınbakiyesi;
            }
            public void Hesabilgisi()
            {
                Console.WriteLine($"Hesabın No'su {HesapNo} Hesabın Ismi {HesapSahibi} Hesabın bakiyesi {Bakiye}");
            }
            public void ParaYatir(decimal miktar)
            {
                if(miktar > 0)
                {
                    Bakiye +=miktar;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir miktar girin!");
                }
            }
            public bool ParaCek(decimal miktar)
            {
              {
                    if (miktar < 0)
                    {
                        Console.WriteLine("Hata! Çekmek istediğiniz miktar geçerli değil!");
                        return false;
                    }
                    else if (miktar > Bakiye)
                    {
                        Console.WriteLine("Hata! Çekmek istediğiniz miktar geçerli değil!");
                        return false;
                    }
                    else
                    {
                        Bakiye -=miktar;
                        return true;
                    }
                
            }
       

    }
          
}
    }
}
