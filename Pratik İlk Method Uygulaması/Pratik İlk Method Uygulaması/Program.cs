using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            sarki();
            int sayi = rastgele();
            Console.WriteLine("2. soru =" + sayi);
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = toplam(sayi1, sayi2);
            Console.WriteLine("3. soru =" + sayi3);
            string isim = "Mustafa";
            string soyisim = "Çınar";
            isimler(isim, soyisim);

        }
        static void sarki()
        {
            Console.WriteLine("Güneşe dokundum umudum.");
        }
        static int rastgele()
        {
            Random rnd = new Random();
            int sayi = rnd.Next();
            int kalan = sayi % 2;
            Console.WriteLine("Sayi=" + sayi);
            return kalan;
        }
        static int toplam(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        static void isimler(string ad, string soyad)
        {
            Console.WriteLine($"Hoş Geldiniz {ad} {soyad} ");
        }
    }
}