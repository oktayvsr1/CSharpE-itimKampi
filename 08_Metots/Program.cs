using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Oktay Avşar");
            //    Console.WriteLine("Mehmet Avşar");
            //    Console.WriteLine("deniz Avşar");
            //    Console.WriteLine("zilan Avşar");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Oktay");

            //void CustomerCard(string name,string surnmae)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surnmae);
            //}
            //CustomerCard("Oktay","Avşar");
            #endregion

            #region Geriye değer döndürmeyen ınt parametreli metotlar

            //void sum(int s1,int s2,int s3)
            //{
            //    int result=s1 + s2+s3;
            //    Console.WriteLine(result);
            //}
            //sum(2, 5, 7);
            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Oktay";
            //    string surname = "avşar";
            //    return name+" " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string countrCard(string name,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke "+name+" "+capital+" "+flagColor;
            //    return cardInfo;
            //}
            //Console.Write("Ülke Adını giriniz: ");
            //string x=Console.ReadLine();
            //Console.Write("Ülke Başkenti giriniz: ");
            //string y = Console.ReadLine();
            //Console.Write("Ülke Bayrak rengini giriniz: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(countrCard(x,y,z));


            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int s1,int s2)
            //{
            //    return s1 + s2;
            //}
            //Console.WriteLine(Sum(1,5));

            #endregion

            #region Örnek uygulama

            //string ExamResult(string stu,int s1,int s2, int s3)
            //{
            //    int result = (s1 + s2 + s3)/3;
            //    if (result >= 50)
            //    {
            //        return stu + " İsimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return stu + " İsimli öğrenci sınavı geçemedi " + "Ortalama: " + result;

            //    }

            //}
            //Console.WriteLine(ExamResult("Oktay",55,25,45));

            #endregion



            Console.Read();
        }
    }
}
