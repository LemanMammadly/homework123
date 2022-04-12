using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClass.Models
{
    class Product
    {
        public string ProductName;
        private int _productPrice;
        public int Productprice 
        {
            get 
            {
                return _productPrice; 
            }
            set
            {
                while (value<0)
                {
                    Console.WriteLine("Qiymeti 0 dan boyuk olmalidir..");
                    value=int.Parse(Console.ReadLine());
                }
                _productPrice = value;
                
            }
        }
        public int ProductCount;
        public int ProductTotallnCome;

        

        public Product(string Productname)
        {

        }
        public void Sell()
        {
            int total = ProductTotallnCome;
            while (ProductCount > 0)
            {

                int result = 0;
                int a = 1;
                int b = Productprice;
               

                result = (a * b);
                total += result;

                ProductCount--;
            }
            Console.WriteLine(total);
        }
    }
}