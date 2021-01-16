using System;

namespace Dersintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenler veri tutuculardır.
            // type safety = tip güvenliği. veri türünü adın önüne yazmamız gerek
            //do not rpeat yourself = kendini tekrar etme
            //kategorietkitei bir değer tutucudur, alias=takma ad

            string kategoriEtiketi = "kategori"; //string = yazma,metinsel
            int ogrenciSyisi = 32000;     //int = sayısal veri. belirli bir sayıya kadar gidiyor. eğer daha fazla sayı olurs uyarı veriyor
            double faizOranı = 1.45; //double = ondalıklı sayı
            bool sistemeGirişYapmişMi = true; // bool = TRUE/FALSE değişkenlerden yola çıkarak, programlamaları dallandırma. TRUE/FALSE
            double dolarDun = 7.35;
            double dolarbugun = 7.45;

            if (dolarDun > dolarbugun)
            {
                Console.WriteLine("azalış butonu göster");
            }

            else if (dolarDun < dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }



            













            
            
        }
    }
}
