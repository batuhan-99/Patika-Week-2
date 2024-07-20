using System;

namespace PratikWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini yaparım.");
                i++;
            }
            i = 1;
            while (i < 21)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while(i < 21)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            i = 50;
            int toplam = 0;
            while (i <= 150)
            {
                toplam = toplam + i;
                i++;
            }
            Console.WriteLine("Toplam = " + toplam);
            i = 1;
            int toplamt = 0, toplamc = 0;
            while(i < 121)
            {
                if (i % 2 == 0)
                    toplamc = toplamc + i;
                else
                    toplamt = toplamt + i;
                i++;
            }
            Console.WriteLine("Tek sayıların toplam=" + toplamt + "\n" + "Çift sayıların toplamı=" + toplamc);

        }
    }
}