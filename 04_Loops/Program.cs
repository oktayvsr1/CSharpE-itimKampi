﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For Döngüsü




            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazımasını istediğiniz adeti giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i=1; i<=finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın cumhuriyet");
            //}


            #endregion

            #region For döngüsü ile karar yapıları

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue=totalValue+i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //int bakteri = 1;

            //for(int i = 1;i<=24;i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+".Saat sonunda: "+bakteri);
            //}


            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region Örenk Sınav Sorusu


            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int one, tens, hundred;
            int sum;

            one = number % 10;
            hundred = number / 100;
            tens = number % 100 - one;
            tens = tens / 10;
            sum=one+hundred+tens;

            Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
