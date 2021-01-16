using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            Kitap romanKitabi = new Kitap();
            romanKitabi.kitabinAdi = "Monte Kristo Kontu";
            romanKitabi.kitabinYazari = "Alexandra Dumas";
            romanKitabi.kitabinYazari = 50;

            Kitap tarihKitabi = new Kitap();
            tarihKitabi.kitabinAdi = "Nutuk";
            tarihKitabi.kitabinYazari = "Mustafa Kemal ATATÜRK";
            tarihKitabi.kitabinFiyati = 85;

            Kitap cocukKitabi = new Kitap();
            cocukKitabi.kitabinAdi = "Ayşegül okulda";
            cocukKitabi.kitabinYazari = "Anonim";
            cocukKitabi.kitabinFiyati = 10

            Kitap[] kitaplar = new kitaplar[] {romanKitabi, tarihKitabi, cocukKitabi };
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap.kitabinAdi +"=" + kitap.kitabinYazari);
            }

        }
        class Kitap
        {
            public string kitabinAdi { get; set; }
            public string kitabinYazari { get; set; }
            public int kitabinFiyati { get; set; }

        }
        
    }
}
