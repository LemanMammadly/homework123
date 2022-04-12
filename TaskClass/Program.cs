using System;
using TaskClass.Models;
namespace TaskClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mehsulun adini daxil edin: ");
            Product product = new Product(Console.ReadLine());
            Console.WriteLine("Mehsulun qiymetini daxil edin: ");
            string price = Console.ReadLine();
            int pprice = int.Parse(price);
            product.Productprice = pprice;
            Console.WriteLine("Mehsulun sayini yazin: ");
            string count=Console.ReadLine();
            int pcount = int.Parse(count);
            product.ProductCount= pcount;

            product.Sell();
       
        }
    }
}
