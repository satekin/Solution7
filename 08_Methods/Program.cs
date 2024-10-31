using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer ---> Listele, Ekle, Sil, Güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Luna");
            //    Console.WriteLine("Tekin");
            //    Console.WriteLine("Console");
            //    Console.WriteLine("Merkür");

            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();



            //void Sum()
            //{
            //    int x = -8;
            //    int y = 10;
            //    int z = 20;
            //    int t = x + y + z;
            //    Console.WriteLine(t);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar


            //void WriteMethod (string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("John Nash");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " +  name + " " +  surName);
            //}

            //CustomerCard("Samed", "Tekin");
            //CustomerCard("Ellie", "Linds");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,  int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(31, 4, -78);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Keskin";
            //    return name + " " + surname; 
            //}

            //Console.WriteLine(StudentCard());






            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string countryCapital, string flagColor)
            //{
            //    string cardInfo = ("Ülke: " + countryName + "- Başkent: " + countryCapital + "- Bayrak Rengi: " + flagColor);
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adı Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı/Beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 * number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(78, 50));
            //Console.WriteLine(Sum(7, 5));
            //Console.WriteLine(Sum(8, 50));
            //Console.WriteLine(Sum(78, 5));
            //Console.WriteLine(Sum(8, 0));



            #endregion


            #region Örnek Uygulama



            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti." + " Sınav ortalaması: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız oldu." + " Sınav ortalaması: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 67, 38, 40));
            //Console.WriteLine(ExamResult("Fatma", 23, 59, 100));


            #endregion


            Console.Read();


        }
    }
}
