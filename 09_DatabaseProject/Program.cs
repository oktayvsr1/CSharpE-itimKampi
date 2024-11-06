using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# veri tabanlı ürün-kategori bilgi sistemi ****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            string bgl = @"Server=DESKTOP-7HJ6BE6\SQLEXPRESS01;Database=EgitimKampiDb;Trusted_Connection=true;TrustServerCertificate=true";
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine(); 
            Console.WriteLine("------------------------------------");
            
            SqlConnection con= new SqlConnection(bgl);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from categories",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            foreach(DataRow row in dt.Rows)
            {
                 
               foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
