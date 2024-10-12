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

            #region Temel dizi örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lion";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;
            //Console.WriteLine(numbers[2]);

            //string[] cities = { "Prag","Roma","Atina","Ankara"};
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki tüm elemanları listeleme
            //string[] color = { "SArı", "Kırmızı", "Beyaz", "MAvi", "turuncu", "Pembe" };
            //for (int i = 0; i < color.Length; i++)
            //{
            //    Console.WriteLine(color[i]);
            //}



            //int[] numbers = {4,85,74,125,638,66,520,75,2365,1120 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c','*','/','-' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47,85,95,41,25,635,789,86,100};
            //int max=myArray[0];
            //for(int i = 1; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }
            //}
            //Console.WriteLine(max);



            #endregion

            #region Dizi metotları

            //string[] persons = { "ALi","Ahmet","Ayşe","buse","cem","deniz"};
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45,85,52,41,86,10,22,35};
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] number2 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(number2);
            //for (int i = 0; i < number2.Length; i++)
            //{
            //    Console.WriteLine(number2[i]);
            //}

            //string[] custoers = { "ali","buse","ayşegül","merve","çınar","kaya"};
            //int index = Array.IndexOf(custoers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45,85,96,63,74,10,25,22,36};
            //Console.WriteLine("Dizinin en büyük elemanı: "+numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: "+numbers.Min());





            #endregion

            #region kullanıcıdan değer alma

            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}   
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Console.WriteLine("Çift sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine("Tek Sayılar");
            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
