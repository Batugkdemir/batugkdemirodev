using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;

namespace gazi.kararyapıları.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1.Sayı");
            //int s1=int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int s2=int.Parse(Console.ReadLine());

            //if (s1>s2)
            //{
            //    Console.WriteLine("Sayı 1 Büyüktür");
            //}
            //else if (s2>s1)
            //{
            //    Console.WriteLine("Sayı 2 Büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar Esittir");
            //}

            //Console.WriteLine("İsminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("");
            //Console.WriteLine("Soyisminizi Giriniz");
            //string soyisim = Console.ReadLine();
            //Console.WriteLine("");
            //Console.WriteLine("Yaşınızı Giriniz");
            //byte yas1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine("-----------Bilgiler-----------");
            //Console.WriteLine($"--İsim: {isim}");
            //Console.WriteLine($"--Soyisim: {soyisim}");
            //Console.WriteLine($"--Yaş: {yas1}");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("");

            //Console.WriteLine("İsminizi Giriniz:");
            //string isim2 = Console.ReadLine();
            //Console.WriteLine("");
            //Console.WriteLine("Soyisminizi Giriniz");
            //string soyisim2 = Console.ReadLine();
            //Console.WriteLine("");
            //Console.WriteLine("Yaşınızı Giriniz");
            //byte yas2 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine("-----------Bilgiler-----------");
            //Console.WriteLine($"--İsim: {isim2}");
            //Console.WriteLine($"--Soyisim: {soyisim2}");
            //Console.WriteLine($"--Yaş: {yas2}");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("");

            //if (yas1 > yas2)
            //{
            //    Console.WriteLine($"{isim} Büyüktür");
            //}
            //else if (yas2 > yas1)
            //{
            //    Console.WriteLine($"{isim2} Büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşıtlardır");
            //}

            //Console.WriteLine("1.Sayı");
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Hangi İşlemi Yapmak İstersin?:+,-,*,/");
            //char islem=char.Parse(Console.ReadLine());

            //string msg = "İşlemin Sonucu";

            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg}{s1 + s2}");
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{msg}{s1 - s2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg}{s1 * s2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{msg}{s1 / s2}");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı İşlem");
            //}

            //Console.WriteLine("Dil Seçiniz/Select Language TR/EN");
            // string cevap=Console.ReadLine();

            // string msg1, msg2, msg3, msg4, msg5;

            //if (cevap.ToUpper()== "TR")
            //{
            //    msg1 = "Bir Sayı Giriniz";
            //    msg2 = "Bir Sayı Daha Giriniz";
            //    msg3 = "İşlem Seçiniz";
            //    msg4 = "Sonuç:";
            //    msg5 = "Hatalı İşlem Seçtiniz";
            //}

            //else
            //{
            //    msg1 = "Enter First Number";
            //    msg2 = "Enter Second Number";
            //    msg3 = "Select Operation";
            //    msg4 = "Result:";
            //    msg5 = "Eror";
            //}

            //Console.WriteLine(msg1);
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg2);
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg3);
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg4}{s1 + s2}");
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{msg4}{s1 - s2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg4}{s1 * s2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{msg4}{s1 / s2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{msg5}");
            //}

            //Console.WriteLine("Hava Nasıl");
            //string cevap = Console.ReadLine();

            //if (cevap.ToLower() == "güzel" || cevap.ToLower() == "iyi")
            //{
            //    Console.WriteLine("Kaç Derece?");
            //    sbyte s1 = sbyte.Parse(Console.ReadLine());
            //    if (s1 <= 15)
            //    {
            //        Console.WriteLine("Evde Kal Hava Soğuk");
            //    }

            //    else if (s1 >= 15 && s1 <= 40)
            //    {
            //        Console.WriteLine("Hava iyi Dışarı Çık");
            //    }

            //    else if (s1 >= 40)
            //    {
            //        Console.WriteLine("Hava Çok Sıcak Evde Kal");
            //    }

            //}
            //else if (cevap.ToUpper() == "Hava Kötü")
            //{
            //    Console.WriteLine("Evde Kal");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}

            //Exception Handing
            //try
            //{
            //    Console.WriteLine("Hava Nasıl");
            //    string cevap = Console.ReadLine();

            //    if (cevap.ToLower() == "güzel" || cevap.ToLower() == "iyi")
            //    {
            //        Console.WriteLine("Kaç Derece?");
            //        sbyte s1 = sbyte.Parse(Console.ReadLine());
            //        if (s1 <= 15)
            //        {
            //            Console.WriteLine("Evde Kal Hava Soğuk");
            //        }

            //        else if (s1 >= 15 && s1 <= 40)
            //        {
            //            Console.WriteLine("Hava iyi Dışarı Çık");
            //        }

            //        else if (s1 >= 40)
            //        {
            //            Console.WriteLine("Hava Çok Sıcak Evde Kal");
            //        }

            //    }
            //    else if (cevap.ToUpper() == "Hava Kötü")
            //    {
            //        Console.WriteLine("Evde Kal");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Giriş");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sadece Sayı Giriniz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 Arası Sayı Giriniz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bilinmeyen Bir Hata Oluştu");
            //    Console.WriteLine($"Hata Mesajı:{ex.Message}\nTarih:{DateTime.Now}\nDetaylar:{ex.StackTrace}");
            //}
            Console.WriteLine("Bir Sayı Giriniz");
            byte sayi = byte.Parse(Console.ReadLine());

            if (sayi==1)
            {
                Console.WriteLine("Bir");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("İki");
            }
            else if (sayi==3)
            {
                Console.WriteLine("Üç");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş!");
            }

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                default:
                    Console.WriteLine("Yanlış Giriş!");
                    break;
            }
        }
    }
}
