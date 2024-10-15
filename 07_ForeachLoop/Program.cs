using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = {"milano","roma","budapeşte","ankara","istanbul","varşova"};

            //foreach(var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 45,78,985,74,11,22,33,41,205};
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 6, 7,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek sınav sistemi uygulaması

            Console.Write("**** C# Eğitim Kampı Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıfatki öğrenci sayısı alma
            Console.WriteLine("--------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            //Öğrenci isimleri ve not ortalamalarını saklayacak diziler
            string[] studentName= new string[studentCount];
            double[] studentsExamAverage= new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentName[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double values=double.Parse(Console.ReadLine());
                    totalExamResult += values; 
                }
                Console.WriteLine();
                studentsExamAverage[i] = totalExamResult/3;
            }
            
            //Sınav ortalamaları
            for(int i=0;i<studentCount;i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentsExamAverage[i]}");
                if (studentsExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğreci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
                }
            }
            //Öğrencilerin ortalaması ve geçip kalma durumları

            #endregion

            Console.Read();
        }
    }
}
