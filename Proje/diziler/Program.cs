using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Ayı","Maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilerde değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            // Döngülerle dizi kulanımı
            // Klavyede girilen n tane sayının ortalamasını hesaplayan program

            Console.Write(" Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write(" Lütfen {0}. sayısını giriniz:", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayı in sayıDizisi)
                   toplam += sayı;

            Console.WriteLine(" Ortalama: " + toplam/diziUzunlugu);       
                
            
        }
    }
}
