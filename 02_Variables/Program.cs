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
            #region Double değikenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potate, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potate = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: "+applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı: "+orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: "+strawberryPrice);
            //Console.WriteLine("---- patates Birim Fiyatı: "+potate);
            //Console.WriteLine("---- Domates Birim Fiyatı: "+tomato);
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potateGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potateGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice=orangeGram*orangePrice;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potateTotalPrice = potateGram * potate;
            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine("Alınan ürün : Elma - "+" Birim fiyat: " +applePrice+" - Gramaj: "+appleGram+" - Toplam tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan ürün : portakal - "+" Birim fiyat: " +orangePrice+" - Gramaj: "+orangeGram+" - Toplam tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan ürün : Çilek - "+" Birim fiyat: " +strawberryPrice+" - Gramaj: "+strawberryGram+" - Toplam tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün : Patates - "+" Birim fiyat: " +potate+" - Gramaj: "+potateGram+" - Toplam tutar: "+potateTotalPrice);
            //Console.WriteLine("Alınan ürün : Domates - "+" Birim fiyat: " +tomato+" - Gramaj: "+tomatoGram+" - Toplam tutar: "+tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potateTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışveriş toplam tutar: "+shoppingTotalPrice);

            #endregion

            #region Char değişkenler
            //char symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden veri girişleri string değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentity;
            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlce Bilgisi: ");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu TCNO: ");
            //passengerIdentity =Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Yolcu TCNO: "+passengerIdentity+" - Yolcu Ad Soyad: "+passengerName+" "+passengerSurname+" "+passengerDistrict+" "+passengerCity+" "+passengerAge);


            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse( Console.ReadLine());

            //int totalPrice=shoePrice*shoeCount + computerPrice*computerCount+tvPrice*tvCount+chairPrice*chairCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: "+totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı işleleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1 + exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result);

            #endregion

            #region klavyeden karakter girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);

            #endregion

            Console.Read();
        }
    }
}
