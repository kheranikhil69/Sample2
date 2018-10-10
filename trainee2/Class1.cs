using System;
using System.Collections.Generic;
using System.Text;

namespace trainee2
{
    class Product

    {
        public int Productid { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public Product()
        {
            Productid = 0;
            title = "";
            price = 0;



        }
        public Product(int Productid, string title, float price)
        {


            this.Productid = Productid;
            this.title = title;
            this.price = price;


        }

        public string getproductdetails()
        {
            return $"id :{Productid} title:{title} price{price}";


        }
    }
    class store
    {
        public static List<Product> Productlist;
        static store()
        {

            Productlist = new List<Product>()
            {
                new Product(100,"pencil",200),

            new Product(100, "pencil", 200),

            new Product(101, "stensil", 220),

            new Product(102, "glue", 250),

            new Product(103, "sharpner", 350),

            new Product(104, "notebook", 150),
        };
             }
    } 

}

    



