using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak console dan girilen sayıya kadar(sayıda dahil) ortalama hesaplayıp console a yazdıran program
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayı)
            {
                toplam += sayac;
                sayac ++;

            }
            Console.WriteLine(toplam/sayı);

            // a dan z ye kadar olan tüm harfleri yazdır

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character ++;
            }
            
            Console.WriteLine("**** FOREACH ****");
            string[] arabalar = {"BMW","FORD","MERCEDES","TOYOTA"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
