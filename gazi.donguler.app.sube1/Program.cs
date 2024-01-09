using System.ComponentModel.Design;
using System.Runtime;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace gazi.donguler.app.sube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz.");
            //string a = Console.ReadLine();
            //Console.WriteLine("İsim kaç kere yazılsın");
            //int b = int.Parse(Console.ReadLine());
            //try
            //{
            //    Console.WriteLine("Başlangıç Değeri Giriniz:");
            //    int baslangıc = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Son Değeri Giriniz");
            //    int bitis = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Çift mi tek mi?");
            //    int sonuc = 0;
            //    string cevap = Console.ReadLine();

            //    if (baslangıc > bitis)
            //    {
            //        int temp = baslangıc;
            //        baslangıc = bitis;
            //        bitis = temp;
            //    }
            //    for (int i = baslangıc; i <= bitis; i++)
            //    {
            //        if (i % 2 == (cevap == "tek" ? 1 : 0))
            //        {
            //            Console.WriteLine(i);
            //            sonuc = sonuc + i;
            //        }
            //    }
            //    Console.WriteLine(sonuc);
            //}
            //catch (FormatException) 
            //{
            //    Console.WriteLine("Sayı Olarak Giriniz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Yüksek bir değer girildi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu");
            //}
            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac == 2 ? "Asal" : "Asal Değildir!");
            //for (;;)
            //{
            //    Console.WriteLine("Kullanıcı Adı Giriniz");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Şifre Giriniz");
            //    string password = Console.ReadLine();
            //    string ad = "batu";
            //    string sifre = "gökdemir";
            //    if (username ==ad & password==sifre)
            //    {
            //        Console.WriteLine("Doğru");
            //        break;

            //    }
            //    else 
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Tekrar deneyiniz");
            //    }
            //}
            //int max = 0;
            //int toplam = 0;
            //int ortalama = 0;
            //for (;;)
            //{
            //    Console.WriteLine("Sayı Giriniz");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    ortalama++;
            //    toplam += sayi1;
            //    if (sayi1 > max) 
            //    {
            //        max = sayi1;
            //    }
            //    Console.WriteLine("Devan Etmek İstiyormusunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "H") 
            //    {
            //        ortalama = toplam/sayi1;
            //        break;
            //    }
            //}
            //Console.WriteLine($"Girdiğiniz en büyük sayı:{max}\nSayıların Toplamı:{toplam}\nGirilen Sayıların Ortalaması:{toplam/ortalama}");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}   

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((j + i) % 2 == 0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter Row Count:");
            //int satir =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Column Count:");
            //int sutun =int.Parse(Console.ReadLine());
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun ; j++)
            //    {
            //        if ((j + i) % 2 == 0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int a  = 0; a <= 9; a++)
            //{
            //    for (int b = 0; b <= 9; b++)
            //    {
            //        for (int c = 0; c <= 9; c++)
            //        {
            //            for (int d = 0; d <= 9; d++)
            //            {
            //                if ((a*1000+b*100+c*10+d)==4*(d*1000+c*100+b*10+a)) 
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    for (int j = 1; j <= 100; j++)
            //    {
            //        for (int k = 1; k <= 100; k++)
            //        {
            //            if ((i*i+j*j)==k*k)
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }
            //        }
            //    }
            //}

            //int bas = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Enter Starting Number");
            //    bas = int.Parse(Console.ReadLine());
            //    if (bas >= 2)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("2 den büyük değer giriniz");
            //    }
            //}

            //Console.WriteLine("Enter End Number");
            //int son = int.Parse(Console.ReadLine());
            //for (int i = bas; i < son; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i/2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //           count++;
            //            break;
            //        }

            //    }
            //    Console.WriteLine(count > 0 ? $"{i}-Is not prime": $"{i}-Prime");
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir Sayı giriniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    Console.WriteLine("Bir Sayı Daha Girmek İstiyomusunz ?");
            //    string cevap2 = Console.ReadLine();
            //    if (cevap2 == "H") 
            //    {
            //        Console.WriteLine(toplam);
            //        break;
            //    }
            //}
            //int toplam = 0;
            //string cevap;
            //do
            //{
            //    Console.WriteLine("Bir Sayı Giriniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine("Devam Etmek İstiyor musunuz?");
            //    cevap = Console.ReadLine();
            //} while (cevap == "Y");
            //Console.WriteLine(toplam);

            //Random rnd = new Random();
            //int number = rnd.Next(1, 11);
            //int number2;
            //do
            //{
            //    Console.WriteLine("Bir Sayı Tahmin Ediniz");
            //    number2 = int.Parse(Console.ReadLine());
            //    if (number2 != number)
            //    {
            //        Console.WriteLine("Cevap Yanlış");
            //    }
            //} while (number2 != number);
            //Console.WriteLine($"Cevap Doğru:{number}");

            //Random rnd = new Random();
            //int seviye = 11;
            //int number = rnd.Next(1, seviye);
            //int number2;
            //int hak = 3;
            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.WriteLine("Seviye seçiniz");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "orta")
            //    {
            //    }
            //    Console.WriteLine("Sayıyı Tahmin Ediniz");
            //    number2= int.Parse(Console.ReadLine());
            //    if (number2 == number)
            //    {
            //        Console.WriteLine("Doğru Tahmin");
            //        Console.WriteLine(number);
            //        seviye= seviye +10;
            //    }
            //    else if (number2 != number)
            //    {
            //        hak--;
            //        Console.WriteLine($"Yanlış tahmin {hak} hakkınız kaldı");
            //    }

            Random rnd = new Random();
            int seviye = 11;
            int number = rnd.Next(1, seviye);
            int number2;
            int hak = 3;
            Console.WriteLine("Bir seviye seçiniz:Kolay/Orta/Zor");
            string cevap = Console.ReadLine();
            if (cevap =="orta")
            {
                seviye += 10;
            }
            if (cevap == "zor")
                seviye += 20;

            while (hak>0)
            {
                Console.WriteLine("Bir sayı tahmin ediniz");
                number2 = int.Parse(Console.ReadLine());
                if (number2 != number)
                {
                    Console.WriteLine("Cevap Yanlış");
                    hak--;
                    Console.WriteLine($"Kalan Hakkınız:{hak}");
                }
                if (number2 == number)
                {
                    Console.WriteLine("Doğru Bildiniz");
                    seviye += 10;
                }
                else if (hak == 0)
                {
                    Console.WriteLine($"Bilemediniz Cevap:{number}");
                }
            }

        }

    }
}