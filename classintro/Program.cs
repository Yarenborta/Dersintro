using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ENGİN";
            int yas = 36;

            //kendime yeni bir değişken oluşturdum. sting, double gibi.classta bir kur sdeğişkeni tanımlamak istiyorsak onu bu şekilde tanımlarız.
            //stirng, ing gibi değişken tanımlanabiliryorsa "Kurs" diye de bir değişken tanımlayabiliriz.

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 80;
            kurs1.KursAdi = "python";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "berkay";
            kurs2.IzlenmeOrani = 68;
            kurs2.KursAdi = "c#";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "murat";
            kurs3.IzlenmeOrani = 64;
            kurs3.KursAdi = "java";

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3   };

            foreach (var kurs in kurslar) //kurs yazmasak başka şey de yazabiliriz.
            {
                //Console.WriteLine(kurs.KursAdi); //kurs1.KursAdi değil çünkü kursları dolaşan kurs(yada x,m t ne demek istiyorsan)
                Console.WriteLine(kurs.KursAdi + " :" + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; } //prop yazıp 2 defa tab tuşuyla çağırdık.
        //Şu an artık bizim değişkenimiz KURS(class Kurs) oldu. yani biz objeyi oluşturmuş oluyoruz. her şeyi bir kutuda topluyormuşuz gibi=klasör.
        public string   Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        // yukarıda belirttiğimiz kurs1'ler de class için tanımladığımız değer atmalardır.
        //class içindekiler de klasör gibi düşünelim
        


    }





}
