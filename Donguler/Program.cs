using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //döngüler bir şeyleri tekrar etmek için kullanılan yapılardır.
            //array = dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs","java" };

            for (int i = 0; i <kurslar.Length; i++)
                // i'yi 2şer 2şer arttırmak istersek eğer i++ yerine (i = i+2) ya da i+=2 de yazabiliriz.

                // bir sürü ürün geliyor ve bunun sonu yok bu yüzden de (i<kurslar.Length); dememiz gerekiyor. kaç eleman var ise onu söyler.
            {
                Console.WriteLine(kurslar[i]); //kursların i'ninci elemanı çalışması için bu şekil yazmalıyız çünkü kurslardaki kursu istiyoruz onun döngüsüne göre de i ile oluşturduk ki sırayla kursların yazılması gerek, ikisini birleştirmemiz gerekm ki kod çalışsın

            }
            Console.WriteLine("FOR BİTTİ");
             
            //////////////////////////////////


            foreach (string kurs in kurslar) // dizi tmelli yapıları tek tek dönmeye yarar.
                //kursları tek tek dolaş. kurs yerine abc,tmn falan da diyebilirz. yani kursların içindeki kursları dolaş(alias)
            {

                Console.WriteLine(kurs);
            }





            Console.WriteLine("sayfa sonu-footer");
























        }
    }
}
