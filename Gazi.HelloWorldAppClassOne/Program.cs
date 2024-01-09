using System.Threading.Channels;

namespace Gazi.HelloWorldAppClassOne
{
    internal class Program
    {
        static int sayi = 80;
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("@Batuone__");
            Console.WriteLine("");

            //byte s = 30;
            //double l = 40;
            // Console.WriteLine(s + l);

            //byte a, b;
            //a = 50; b = 60;
            //int number = 100;

            //console.Writline(number);
            //number = 50
            //console.Writline(number);

            //const int number = 100; (const değeriyle verildiğinde sonradan değiştirilemez. const değeriyle aynı satırda verilmelidir!!!!)
            //const byte a; a=30; (bu çalışmaz) const byte a = 30; (bu şekilde doğrusu sadece const değeri için)

            //byte s1 = 50;
            //short s2 = 50;
            //int s3 = 50;
            //long s4 = 50;

            //string isim = "Batuhan";
            //var isim = "Batuhan";
            //var sayi = 5.4D;

            //string soyad = "Batuhan";
            //string isim = "Muhammet";

            //Console.WriteLine("Merhaba"+ " " +isim+ " " +soyad);
            //Console.WriteLine("Merhaba {0} {1}",isim,soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");

            Console.WriteLine("İsminizi Giriniz:");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi Giriniz");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Yaşınızı Giriniz");
            byte yas = byte.Parse (Console.ReadLine());

            


             
            byte number = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("--------Bilgiler--------");
            Console.WriteLine($"--İsim: {isim}");
            Console.WriteLine($"--Soyisim: {soyisim}");
            Console.WriteLine($"--Yaş: {number}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Birinci Sayıyı Giriniz");
            int sayi1=int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            int sayi2=int.Parse(Console.ReadLine());
            Console.WriteLine("Sonuç");
            Console.WriteLine(sayi2 + sayi1);
            

            //double maas = 5000;
            //maas += 1000;//maas=maas+1000
            //Console.WriteLine(maas);            

            //int sayi1 = 10;
            //int sayi2 = 10;

            //string sonuc = sayi2 > sayi1 ? "Sayı 2 Büyüktür" : "Sayı 1 > Sayı 2 büyüktür yada sayılar eşittir";
            //Console.WriteLine(sonuc);






        }
    }
}
//Bit: 0-1
//8 Bit = 1 Byte
//1024 Byte = 1 Kilobyte (KB)
//1024 KB = 1 MegaByte (MB)
//1024 MB = 1 Gigabyte (GB)
//1024 GB = 1 Terebyte (TB)

//Binary: 2'li sayı sistemi
//Decimal: 10 tabanlı sayı sistemi

//float f = 3.12f; veya float f = 3.12F; (32 bit)
//double a = 3.12d; veya double a =3.12D; (64 bit)
//decimal a = 3.12m; veya decimal a = 3.12M; (128 bit)
//bool (doğru veya yanlış (true veya false) değerlerini saklamak için kullanılır.) bool sonuc = false;
//char (tek bir karakter saklamak için kullanılır. 16 bitlik alan kaplar. Burada char tipi değişkene atanan değer tek tırnaklar (' ') arasına yazılır.)
//string (metinsel verileri saklamak için kullanılan değişken tipidir. (" ") işareti arasında yazılır. string isim="batuhan gökdemir";)
/*
//namespace: İçinde Classları bulunduran yapılardır.
//{ }: Blok yapıları (Scope)
//Class:  İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulanmalarınan giriş noktasıdır.Bulunması zorunludur.
//Syntax: Kod yazım kuralları
//Build-> Derleme(Complie)
//Solution: İçinde birden fazla proje bulundurabilen yapıları solution denir.
//control+B-->Derleme

//MS-IL: Miscorosft İntermediate Languae

//c#->Build->IL(exe)-Runtime->JIT Compiler->Binary(0-1)
-Runtime: Çalışma zamanı
.net Core->Core Common Language Runtime
JIT: Just İn Tİme
Compiler: Derleyici

.NET: Microsoft tarafından yazılım geliştirmek için tasarlanan bir framework. 
İçinde programlama dilleri.editörler,derleyiciler. kütüphaneler bulunur.
- Programlama Dilleri- C#- Visual Basic- F#
- Editör: Visual Studio-Visual Studio Code
- Kütüphaneler(Library): İçinde classlar bulunur.
- Derleyiciler: Kodları makina diline çevirmek için gerekli yazılımlar bulunur.

- Desktop(Masaüstü)
- Web Based Software(Web Tabanlı yazılım)
- Mobile Apllication (Android-iOS) Xamarin ile
- Game Software (Unity İle]
- İot: İnternet of Things(Akıllı cihazlar için yazılımlar)
-Ai (Yapay Zeka) uygulamaları yapılabilir.

Cross Platform: Windos, macos,Linux işletim sistemlerinde çalışabilen uygulamalar.

.Net Fremework: Windows
.Net COre: Cross Platform
*/
/*  0 && 0 = 0
    0 && 1 = 0
    1 && 0 = 0
    1 && 1 = 1

    0 || 0 = 0
    0 || 1 = 1
    1 || 0 = 1
    1 || 1 = 1 
    
    C# Tip Güvenliği (Type Safety) sağlayan bir programlama delidir. Bu özellik, veri tipine uygun olmayan tipte değer atanmasının önüne geçer. Eğer bu değeri uygun hale getirerek
atamak istersek, TÜR DÖNÜŞÜMÜ(Type Casting) yapmamız gerekir.

    Tür Dönüşümleri(Type Casting)
    
    byte sayi = 20;
    int number = sayi; // Implicit Type Casting

    int sayi = 20;
    byte number = (byte)sayi; //Explicit Type Casting 
    Büyük tür-> Küöük tür Risk: Değer Kaybı 
    ctrl+k+s checked kontrol eder.

    string->değer türlerine

    string sayi = "25";
    byte number = Convert.ToByte(sayi);
    int number = Convert.ToInt(sayi);
    int number = int.Parse(sayi);

*/
 
 