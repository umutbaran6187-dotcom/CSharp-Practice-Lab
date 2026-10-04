using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
class Program
    {
      
        static void Main(string[] args)
        {
        KargoPaketi paket1=new KargoPaketi("Mısır",30);
        UzayGemisi gemi1=new UzayGemisi("Elisabeth",100,200);
        HizliFirkateyn hzl1=new HizliFirkateyn("Merve",80,100);
        bool gemi1aktif=true;
        bool hzl1aktif=true;
        while (true)
        {
        if(!hzl1aktif && !gemi1aktif)
            {
                Console.WriteLine("İki gemide sefere çıkamıyor");
                break;
            }
            if (hzl1aktif)
            {
                bool sonuc=hzl1.KargoTasi(paket1);
                if (!sonuc)
                {
                    hzl1aktif=false;
    
                }
            }
            if (gemi1aktif)
            {
                bool sonuc=gemi1.KargoTasi(paket1);
                if (!sonuc)
                {
                    gemi1aktif=false;
            
                }
            }

     }     }     
           
}   
   
        
    class KargoPaketi
    {
        public string KargoAdi;
        public int agirlik;
        public KargoPaketi(string KargonunAdi,int kargonunagirligi){
            KargoAdi=KargonunAdi;
            agirlik=kargonunagirligi; 
        }
        public void BilgiYazdir()
        {
            Console.WriteLine($"Kargonun Adı {KargoAdi},Kargonun ağırlığı {agirlik}");
        }
    }


class UzayGemisi
    {
        public string Gemiadi;
        public int KalanYakit{get;protected set;}
        protected int Kapasite;
        public UzayGemisi(string GemininAdi,int gemininyakiti,int gemininkapasitesi)
        {
        Gemiadi=GemininAdi;
        KalanYakit=gemininyakiti;
        Kapasite=gemininkapasitesi;
    
    
      }  
    public virtual bool KargoTasi(KargoPaketi paket)
    {
        if (KalanYakit <10)
        {
            Console.WriteLine($"Yakıt bitti,sefer iptal!.{Gemiadi} Adlı geminin {KalanYakit} kaldı.Bu kadar az yakıt ile sefer yapamaz. ");
            return false;
        }
        else if (paket.agirlik>Kapasite)
        {
            Console.WriteLine("Kargo çok ağır bu gemi bunu taşıyamaz");
            return false;
        }
        else
        {
            KalanYakit-=10;
            Console.WriteLine($"{Gemiadi},{paket.KargoAdi} kargosunu başarıyla taşıdı.{KalanYakit} Yakıt kaldı.");
            return true;
        }
    }
     }  
     class HizliFirkateyn : UzayGemisi
{
    public HizliFirkateyn(string firkateynAdi, int firkateynYakiti, int firkateynKapasitesi)
    :base(firkateynAdi,firkateynYakiti,firkateynKapasitesi)
    {
        
    }
    public override bool KargoTasi(KargoPaketi paket)
    {
      if (KalanYakit <25)
        {
            Console.WriteLine($"Yakıt bitti,sefer iptal!.{Gemiadi} Adlı geminin {KalanYakit} kaldı.Bu kadar az yakıt ile sefer yapamaz. ");
            return false;
        }
        else if (paket.agirlik>Kapasite)
        {
            Console.WriteLine("Kargo çok ağır bu gemi bunu taşıyamaz");
            return false;
        }
    
        else
        {
            KalanYakit-=25;
            Console.WriteLine($"{Gemiadi},{paket.KargoAdi} kargosunu başarıyla taşıdı.{KalanYakit} Yakıt kaldı.");
            return true;
        }  
    }
 }
     
    
