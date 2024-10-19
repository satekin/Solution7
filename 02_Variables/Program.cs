using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            //double number;
            //number = 4.45;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " +  strawberryPrice + " TL ") ;
            //Console.WriteLine("---- Patates Birim Fiyatı: " +  potatoPrice + " TL   ");
            //Console.WriteLine("---- Domates Birim Fiyatı: " +  tomatoPrice + " TL   ");

            //Console.WriteLine() ;
            //Console.WriteLine() ;

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.75;
            //potatoGram = 4.861;
            //tomatoGram = 3.753;

            //double totalApplePrice = applePrice * appleGram;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Fiyat: " +  totalApplePrice + "TL");
            //Console.WriteLine() ;

            //double totalOrangePrice = orangePrice * orangeGram;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Fiyat: " + totalOrangePrice + "TL");
            //Console.WriteLine() ;

            //double totalStrawberryPrice = strawberryPrice * strawberryGram;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Fiyat: " + totalStrawberryPrice + "TL");
            //Console.WriteLine() ;

            //double totalPotatoPrice = potatoGram * appleGram;
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Fiyat: " + totalPotatoPrice + "TL");
            //Console.WriteLine() ;

            //double totalTomatoPrice = tomatoGram * tomatoGram;
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Fiyat: " + totalTomatoPrice + "TL");  


            //double  alisverisTotalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalPotatoPrice + totalTomatoPrice;
            //Console.WriteLine() ;
            //Console.WriteLine() ;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + alisverisTotalPrice + " TL");







            #endregion

            #region Char Degiskenler
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " +  passengerSurname + " -Bulunduğu İlçe / İl " + passengerDistrict + " / " + passengerCity + " - Yaşı" + passengerAge );


            #endregion

            #region Klavyeden Tam Sayı Girisleri ve Donusumler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 10000;
            //chairPrice = 5000;
            //tvPrice = 15000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız bilsigayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("LÜtfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoePrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz: " +  totalPrice + " TL ");




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaması: " +  result);





            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");

            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);






            #endregion

            Console.Read() ;
        }
    }
}
