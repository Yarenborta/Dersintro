using System;

namespace okumaödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap romanKitap = new Kitap();
            romanKitap.KitapAdi = "Monte Kristo Kontu";
            romanKitap.KitapYazari = "Alexandra Dumas";
            romanKitap.KitapFiyati = 80;

            Kitap tarihiKitap = new Kitap();
            tarihiKitap.KitapAdi = "NUTUK";
            tarihiKitap.KitapYazari = "Mustafa Kemal ATATÜRK";
            tarihiKitap.KitapFiyati = 110;

            Kitap cocukKitap = new Kitap();
            cocukKitap.KitapAdi = "Ayşeşgül okulda";
            cocukKitap.KitapYazari = "Anonim";
            cocukKitap.KitapFiyati = 4;

            Kitap[] kitaplar = new Kitap[] { romanKitap, tarihiKitap, cocukKitap };

            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine( kitaplar[i]);

            }

            Console.WriteLine("********************************************");
            
           
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap.KitapAdi + ":" + kitap.KitapYazari + ":" + kitap.KitapFiyati);
            } 
            
        }
        class Kitap
        {
            public string KitapAdi { get; set; }
            public string KitapYazari { get; set; }
            public int KitapFiyati { get; set; }
        }

    }
    
}
