using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HJ6BE6\SQLEXPRESS01;Database=EgitimKampiDb;Trusted_Connection=true;TrustServerCertificate=true");
            #region Kategori ekleme işlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();

            //con.Open();

            //SqlCommand cmd = new SqlCommand("Insert into Categories (CategoryName) values (@p1)",con);
            //cmd.Parameters.AddWithValue("@p1",categoryName);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //Console.WriteLine("Kategori başarı ile eklendi");
            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //// bool productStatus;
            //Console.Write("ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Products (ProductName,ProductPrice,ProductStatus) values(@p1,@p2,@p3)",con);
            //cmd.Parameters.AddWithValue("@p1",productName);
            //cmd.Parameters.AddWithValue("@p2",productPrice);
            //cmd.Parameters.AddWithValue("@p3",true);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");


            //Console.Write("ürün adı: ");
            //productStatus = bool.Parse(Console.ReadLine());



            #endregion

            #region Ürün listeleme işlemi

            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from products",con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach(var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}


            //con.Close();


            #endregion

            #region Ürün silme işlemi
            //Console.Write("silinecek ürün id: ");
            //int id = int.Parse(Console.ReadLine());


            //con.Open();
            //SqlCommand cmd = new SqlCommand("delete from products where ProductId=@p1",con);
            //cmd.Parameters.AddWithValue("@p1",id);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("silme işlemi gerçekleştirildi");
            //con.Close();
            #endregion

            #region Güncelleme işlemi


            Console.Write("Güncellenecek ürün Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek ürün Ad: ");
            string productName=Console.ReadLine();
            Console.Write("Güncellenecek ürün Fiyat: ");
            decimal price = decimal.Parse(Console.ReadLine());  


            con.Open();

            SqlCommand cmd = new SqlCommand("update Products set ProductName=@p1,ProductPrice=@p2 where ProductId=@p3",con);
            cmd.Parameters.AddWithValue("@p1",productName);
            cmd.Parameters.AddWithValue("@p2",price);
            cmd.Parameters.AddWithValue("@p3",productId);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Güncelleme başarılı");

            #endregion


            Console.Read();

        }
    }
}
