using System;

namespace Yolarkadasi
{
    class Program
    {
        static void Main(string[] args)
        {

            bool devam = true;
            int i ;
            int toplam=0 ;
            string tatil = "";
            string arac = "";
            while (devam)
            {
                do
                {
                    Console.WriteLine("Nereye gitmek istersiniz:");
                    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL) " +
                        "\n 2 - Marmaris (Paket başlangıç fiyatı 3000 TL)" +
                        "\n 3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
                    tatil = Console.ReadLine();
                    i = 1;
                    toplam = 0;
                    tatil = tatil.ToUpper();

                    switch (tatil)
                    {
                        case "BODRUM":
                            toplam = toplam + 4000;
                            break;
                        case "MARMARİS":
                            toplam = toplam + 3000;
                            break;
                        case "CESME":
                            toplam = toplam + 5000;
                            break;
                        default:
                            i = 0;
                            Console.WriteLine("Belirttiğiniz tatil yeri bulunamadı.Tekrar deneyiniz.");                    
                            break;

                    }
                } while (i == 0);
                Console.WriteLine("Kaç kişi gidiceksiniz?");
                int kisi = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Ulaşım yolunu seçiniz:1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )" +
                    "\n 2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                    string ulasim = Console.ReadLine();
                    i = 1;
                    if (ulasim == "1")
                    {
                        toplam = toplam + (kisi * 1500);
                        arac = "Kara araci";
                    }

                    else if (ulasim == "2")
                    {
                        toplam = toplam + (kisi * 4000);
                        arac = "Hava araci";
                    }

                    else
                    {
                        Console.WriteLine("Hata lütfen tekrar deneyin.");
                        i = 0;
                    }
                } while (i == 0);

                Console.WriteLine("Lokasyon:" + tatil + " , Kişi sayısı:" + kisi + " , Ulaşım=" + arac + " , Toplam fiyat=" + toplam);
                Console.WriteLine("Başka bir tatil planlamak ister misiniz? (EVET VEYA HAYIR");
                string cevap = Console.ReadLine();
                cevap = cevap.ToUpper();
                if (cevap == "HAYIR")
                    devam = false;
            }
          
            
        }
    }
}