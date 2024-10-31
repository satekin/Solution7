using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2 4 6 8....
            //sarı kırmızı mavi mor...
            //adana ankara denizli izmir.... gibi 

            //DeğişkenTürü [] Dizi Adı = new DeğişkenTürü[Elaman Sayısı]

            //string[] colors = new string[4];
            //{
            //    colors[0] = "Kırmızı";
            //    colors[1] = "Sarı";
            //    colors[2] = "Beyaz";
            //    colors[3] = "Mavi";

            //    Console.WriteLine(colors[1]);
            //}

            //string[] cities = new string[5]; 
            //{
            //    cities[0] = "Milano";
            //    cities[1] = "İstanbul";
            //    cities[2] = "Zurich";
            //    cities[3] = "Bern";
            //    cities[4] = "Bilbao";

            //    Console.WriteLine(cities[4]);
            //}

            //int[] numbers = new int[10];
            //numbers[0] = 9;
            //numbers[1] = 107;
            //numbers[2] = 571;
            //numbers[4] = 18;
            //numbers[5] = 1923;
            //numbers[6] = 1;

            //Console.WriteLine(numbers[4]);


            //string[] cities = { "Prag", "Amsterdam", "Budapeşte", "Denizli", "Köln" };
            //Console.WriteLine(cities[3]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme


            //string[] colors = { "Beyaz", "Siyah", "Mavi", "Mor", "Mürdüm", "Turuncu", "Gri" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 11, 33, 531, 8, 9834, 1109, 7, 52, 400 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 's', '/', '-', '+' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 178, 2019, 5, 41, 29, 602, 1, 4421, 70 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "Mehmet", "Ali", "Samed", "Tekin", "Heyo", "Omo" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 145, 22, 507, 789, 135, 5, 4 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region Dizi Metotları

            //string[] customers = { "Sema", "Samed", "Fatma", "Mehmet", "Öykü", "Deniz" };
            //int index = Array.IndexOf(customers, "Öykü");
            //Console.WriteLine(index);


            //int[] numbers = { 15, 20, 30, 7, 23, 29, 87, 54, -1 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());




            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 1, 21, 30576, 40, 57, 62, 71, 832, 94, 105 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)

            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 1) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



                #endregion

                Console.Read();
        }
    }
}
