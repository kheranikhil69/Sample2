//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace training_1
//{
//    class Book
//    {
//        public string title { get; set; }
//        public int price { get; set; }
//        public void getdetails()
//        {
//            Console.WriteLine("enter the title");
//            title = Console.ReadLine();
//            Console.WriteLine("enter price");
//            price = Convert.ToInt32(Console.ReadLine());
//        }
//        public void displaydetails()
//        {

//            Console.WriteLine("title:{0} price{1}", title, price);



//        }

//        class Mainclass
//        {

//            static void Main(string[] args)
//            {
//                Book[] books = new Book[3];
//                Console.WriteLine("enter the books details");
//                for (int i=0 ; i < 3; i++)
//                {
//                    books[i] = new Book();
//                    books[i].getdetails();





//                }

//                Console.WriteLine("details are");
//                for (int i = 0; i < 3; i++)
//                {
//                    books[i].displaydetails();



//                }






//            }






//        }
//    }
//}