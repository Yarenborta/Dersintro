using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {

            Kitap romankitabi = new Kitap();
            romankitabi.KitapAdi = "Monte kristo kontu";
            romankitabi.KitapYazari = "Alexandra Dumas";
            romankitabi.KitapFiyati = 80;

            Kitap tarihkitabi = new Kitap();
            tarihkitabi.KitapAdi = "Nutuk";
            tarihkitabi.KitapYazari = "Mustafa Kemal ATATÜRK";
            tarihkitabi.KitapFiyati = 110;

            Kitap cocukkitabi = new Kitap();
            cocukkitabi.KitapAdi = "Ayşegül okulda";
            cocukkitabi.KitapYazari = "İpek Dumlu";
            cocukkitabi.KitapFiyati = 4;

            Kitap[] kitaplar = new kitaplar[] { romankitabi, tarihkitabi, cocukkitabi   };

            foreach (var Kitap in kitaplar)
            {
                Console.WriteLine( Kitap.KitapAdi + ":" + Kitap.KitapYazari);
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
