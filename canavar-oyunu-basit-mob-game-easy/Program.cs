
string Zombi = "Zombi";
string Orumcek = "Örümcek"; 
string Dev_Zombi="Dev Zombi";
string soru_1;
int kombo = 0;
Console.WriteLine("Oyuna Başlamak ister misiniz? E/H");
soru_1 = Console.ReadLine();
Random random = new Random();
int oyuncucani = random.Next(1, 100);
while (true)
{
    
int zombi_cani = random.Next(1,100);
int orumcek_cani = random.Next(1,100);
int dev_zombi_cani = random.Next(1,100);
int sayi = random.Next(3);
    if (soru_1 == "E" || soru_1 == "e")
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Canınız {oyuncucani}");
        string[] canavarlar = { Zombi, Orumcek, Dev_Zombi };
        int[] canavarCanlari = { zombi_cani, orumcek_cani, dev_zombi_cani };
        Thread.Sleep(1000);
        Console.WriteLine($"Eyvah düşmanınız {canavarlar[sayi]},");
        string secilenCanavar = canavarlar[sayi];
        int secilenCan = canavarCanlari[sayi];
        Thread.Sleep(1000);
        Console.WriteLine($"Canı {secilenCan}");

        if (secilenCan > oyuncucani)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Maalesef canavar senden güçlü çıktı kaybettin.:(");
            Console.WriteLine($"{kombo} kombo yaptınız");
            break;

        }
        else if(secilenCan==oyuncucani){
            Thread.Sleep(1000);
            Console.WriteLine("Maalesef Birbirinizi öldürdünüz");
            Console.WriteLine($"{kombo} kombo yaptınız");
            break;
        }
        else
        {
            Thread.Sleep(2000);
            Console.WriteLine("Kazandınız.");
            kombo++;
            Console.WriteLine($"Kombo, {kombo} canavar katlettiniz");


        }
    }


    
        else 
        { 
    Console.WriteLine("Oyun Kapatılıyor...");
    return;
    }
}
