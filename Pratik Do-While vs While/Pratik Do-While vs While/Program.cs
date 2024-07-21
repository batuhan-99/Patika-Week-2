using System;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Limit belirleyin.");
            int limit = Convert.ToInt32(Console.ReadLine());
            limit = Math.Abs(limit);
            /*  while (sayac < limit)
              {
                  Console.WriteLine("Ben bir patikalıyım.");
                  sayac++;
              }*/
            do
            {
                Console.WriteLine("Ben bir patikalıyım.");
                sayac++;
            } while (sayac < limit);
        }//Do-while bazı durumlarda while dan daha kullanışlıdır.Çünkü kod en az bir kere çalıştırılacağı için while'daki gibi önceden fazladan
         //bir kod yazma zorunluluğu yoktur
    }
}