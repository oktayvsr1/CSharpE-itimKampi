using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password=Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital,country;
            //Console.Write("Başkeni giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");

            //}
            //else {
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number=int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int s1, s2, s3, average;
            //string result="hata";

            //Console.Write("Sınav1: ");
            //s1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //s2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //s3 = int.Parse(Console.ReadLine());
            //average = (s1 + s2 + s3) / 3;

            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}


            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehit girişi yapınız: ");
            //city =Console.ReadLine();   

            //if(city=="adana" | city=="ankara" | city == "trabzon" | city=="bursa")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");

            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kallanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz");
            //}

            #endregion

            #region mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: "+result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 ==0)
            //{
            //    Console.WriteLine("sayo çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}








            #endregion

            #region char değikenler 
            //char team;
            //Console.Write("Lütfen takım sembolümü giriniz: ");
            //Console.Write("Lütfen takım sembolümü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team =='f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team=='b' | team == 'B')
            //{
            //    Console.WriteLine("BEşiktaş");
            //}
            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("****** C# eğitim kampı restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Ana yemekler");
            //Console.WriteLine("------------------------------------------");
            //string menuItem;

            //Console.WriteLine("detayını görmek istediğinizi menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------Ana Yemekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- körü sosli tavuk");
            //    Console.WriteLine("2- Kızartma tabağı");
            //    Console.WriteLine("3- fasulye pilav");
            //    Console.WriteLine("4- fırında somon");
            //    Console.WriteLine("5- patlıcan musakka");
            //    Console.WriteLine("---------------------Ana Yemekler-------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------Çorbalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- mercimek");
            //    Console.WriteLine("2- ezo gelin");
            //    Console.WriteLine("---------------------Çorbalar-------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------Pizzalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdrniz pizza");
            //    Console.WriteLine("2- margarita");
            //    Console.WriteLine("3- tavuklu pizza");
            //    Console.WriteLine("---------------------Pizzalar-------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------İçecekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("---------------------İçecekler-------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------Tatlılar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- kazan dibi");
            //    Console.WriteLine("2- sütlaç");
            //    Console.WriteLine("---------------------Tatlılar-------------------");
            //    Console.WriteLine();

            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak");break;

            //    case 2: Console.WriteLine("Şubat");break;
            //    case 3: Console.WriteLine("MArt");break;
            //    case 4: Console.WriteLine("Nsan");break;
            //    case 5: Console.WriteLine("mayıs");break;
            //    case 6: Console.WriteLine("haziran");break;
            //    case 7: Console.WriteLine("temuuz");break;
            //    case 8: Console.WriteLine("ağustos");break;
            //    case 9: Console.WriteLine("eylül");break;
            //    case 10: Console.WriteLine("ekim");break;
            //    case 11: Console.WriteLine("kasım");break;
            //    case 12: Console.WriteLine("aralık");break;
            //    default: Console.WriteLine("Hatalı bir giriş "); break;

            //}


            #endregion

            #region switch case hesap makinesi
            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. sayı giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2. sayı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default: Console.WriteLine("Hatalı veri girişi:");
            //        break;
            //}

            #endregion
            Console.Read();
        }


    }
}
