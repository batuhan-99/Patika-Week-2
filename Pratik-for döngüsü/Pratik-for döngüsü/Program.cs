using System;

namespace pratikfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=0;i<10;i++)
                Console.WriteLine("Kendime inanıyorum ,ben bu yazılım işini yaparım");
            for (i = 1; i < 21; i++)
                Console.Write(i + " ");
            Console.WriteLine();
            for(i= 1; i < 21; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + " ");
            }
            int toplam = 0;
            for (i = 50; i < 150; i++)
                toplam = toplam + i;
            int toplamt = 0, toplamc = 0;
            Console.WriteLine(toplam);
            for (i = 1; i < 121; i++)
            {
                if (i % 2 == 0)
                    toplamc = toplamc + i;
                else
                    toplamt = toplamt + i;
                    
            }
            Console.WriteLine("Tek sayilarin toplami=" + toplamt + "\n" + "Çift sayilarin toplami=" + toplamc);

        }
    }
}