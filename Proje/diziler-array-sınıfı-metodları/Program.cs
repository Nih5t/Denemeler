using System;

namespace diziler_array_sınıfı_metodları
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort

            int[] sayıDizisi = {30,3,77,41,25,36,2,88};

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayı in sayıDizisi)
                  Console.WriteLine(sayı);

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayıDizisi);

            foreach (var sayı in sayıDizisi)
                  Console.WriteLine(sayı);

            // Clear
            Console.WriteLine("*** Array Clear ***");    
            Array.Clear(sayıDizisi,2,2);

            foreach (var sayı in sayıDizisi)
                  Console.WriteLine(sayı);

             // Reverse
             Console.WriteLine("*** Array Reverse ***");
             Array.Reverse(sayıDizisi);

            foreach (var sayı in sayıDizisi)
                  Console.WriteLine(sayı);

            // IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayıDizisi,36) +1);

            // Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8] = 56;

            foreach (var sayı in sayıDizisi)
                  Console.WriteLine(sayı);
        }
    }
}
