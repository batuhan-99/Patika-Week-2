using System;
using System.Text;
namespace Hafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Soru
            Console.WriteLine("1. Soru \nMerhaba \n" +
                "Nasılsın? \n İyiyim \n" +
                "Sen nasılsın?");
            //2.Soru
            string soru2 = "Merhaba";
            int S2 = 10;
            Console.WriteLine($"2.Soru string degiskeni{soru2} ,tam sayi degiskeni{S2}");
            //3.Soru
            Random rnd = new Random();
            int rastgelesayi = rnd.Next();
            Console.WriteLine($"3. Soru = {rastgelesayi}");
            //4. Soru
            int rastgelesayi2 = (rnd.Next()) % 3;
            Console.WriteLine($"4.Soru = {rastgelesayi2}");
            //5. Soru
            Console.WriteLine("5.Soru \n Kaç yaşınıdasınız?");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 18)
                Console.WriteLine("-");
            else if (yas > 18)
                Console.WriteLine("+");
            //6. Soru
            Console.WriteLine("6. Soru");
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            //7. Soru
            Console.WriteLine("7. Soru: 2 adet metin giriniz:");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string yedekmetin = s1;
            s1 = s2;
            s2 = yedekmetin;
            Console.WriteLine($"İlk metin = {s1}, İkinci metin = {s2}");
            //8.Soru
            Console.WriteLine("8. soru");
            BenDegerDondurmem();
            //9. Soru
            Console.WriteLine("9. Soru");
            int x = 5;
            int y = 9;
            int toplam = topla(x, y);
            Console.WriteLine("Toplam=" + toplam);
            //10.Soru
            string sonuc = KullaniciDegerAl();
            Console.WriteLine($"Sonuç: {sonuc}");

            //11.Soru
            int yas1 = 15, yas2 = 6, yas3 = 70;
            int enyasli;
            enyasli = enyaslibul(yas1, yas2, yas3);
            Console.WriteLine("11. Soru \n En yasli=" + enyasli);

            //12.Soru
            Console.WriteLine("12. Soru \n");
            int enBuyukSayi = enbuyuksayiyibul();
            Console.WriteLine($"En büyük sayı: {enBuyukSayi}");

            //13. Soru
            Console.WriteLine("Lütfen birinci ismi giriniz:");
            string isim1 = Console.ReadLine();

            Console.WriteLine("Lütfen ikinci ismi giriniz:");
            string isim2 = Console.ReadLine();

            yerdegistir(ref isim1, ref isim2);

            Console.WriteLine($"Birinci isim: {isim1}");
            Console.WriteLine($"İkinci isim: {isim2}");

            //14. Soru
            Console.WriteLine("14.Soru \n");
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            bool ciftMi = tekmiciftmi(sayi);
            Console.WriteLine($"Girilen sayı çift mi? {ciftMi}");

            //15. Soru
            Console.WriteLine("15. Soru");
            Console.WriteLine("Lütfen hızı (km/saat) giriniz:");
            double hiz = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen zamanı (saat) giriniz:");
            double zaman = double.Parse(Console.ReadLine());

            double gidilenYol = gidilenyol(hiz, zaman);
            Console.WriteLine($"Gidilen yol: {gidilenYol} km");

            //16. Soru
            Console.WriteLine("Lütfen yarıçapı giriniz:");
            double yaricap = double.Parse(Console.ReadLine());

            double alan = dairealani(yaricap);
            Console.WriteLine($"Dairenin alanı: {alan} birim kare");

            //17. Soru
            Console.WriteLine("17. Soru");
            string cumle = "Zaman bir GeRi SayIm";

            string buyuk = cumle.ToUpper();
            string kucuk = cumle.ToLower();

            Console.WriteLine($"Büyük harflerle: {buyuk}");
            Console.WriteLine($"Küçük harflerle: {kucuk}");

            //18.Soru
            Console.WriteLine("18. Soru");
            string metin = "    Selamlar   ";
            metin = metin.Trim();

            Console.WriteLine($"Düzenlenmiş metin: '{metin}'");

        }
        static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma.");
        }
        static int topla(int x, int y)
        {
            return x + y;
        }

        static int enyaslibul(int yas1, int yas2, int yas3)
        {
            int enyasli = yas1;
            if (yas2 > enyasli)
                enyasli = yas2;
            if (yas3 > enyasli)
                enyasli = yas3;
            return enyasli;
        }
        static int enbuyuksayiyibul()
        {
            int enBuyuk = int.MinValue;
            string girdi;

            Console.WriteLine("Sayıları giriniz (bitirmek için 'bitir' yazın):");

            while (true)
            {
                girdi = Console.ReadLine();

                if (girdi.ToLower() == "bitir")
                {
                    break;
                }

                if (int.TryParse(girdi, out int sayi))
                {
                    if (sayi > enBuyuk)
                    {
                        enBuyuk = sayi;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                }
            }

            return enBuyuk;
        }
        static void yerdegistir(ref string isim1, ref string isim2)
        {
            string yedek = isim1;
            isim1 = isim2;
            isim2 = yedek;
        }
        static bool tekmiciftmi(int sayi)
        {
            return sayi % 2 == 0;
        }
        static double gidilenyol(double hiz, double zaman)
        {
            return hiz * zaman;
        }
        static double dairealani(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }
        static string KullaniciDegerAl()
        {
            Console.WriteLine("Lütfen true ya da false değerini giriniz:");

            
            string girdi = Console.ReadLine();

            
            bool deger;
            bool basarili = bool.TryParse(girdi, out deger);

            
            if (!basarili)
            {
                return "Geçersiz giriş. Lütfen true ya da false giriniz.";
            }

           
            if (deger)
            {
                return "Kullanıcı true değerini girdi.";
            }
            else
            {
                return "Kullanıcı false değerini girdi.";
            }
        }
    }
}