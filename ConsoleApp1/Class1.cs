//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    struct sales // memoery allocation from stac beacuse it is a STRUCT
//                 // IN CLASSES IT COMES FROM HEAP
//    {
//        public int Units;
//        public int priceperunit;
//        public sales(int units, int unitprice)
//        {
//            Units = units;
//            priceperunit = unitprice;
            
//        }
//        public string getdetails()

//            {
//            string str = $"units:{Units}  price:{priceperunit}";//string interpolation
//            //aternate-"units"+(concatination)+"   price"+priceunit;

//            return str;

//        }
//    }

//    class mainclass
//    {
//        static void Main (string[] args)
//        {
//            sales s1 = new sales();
//            Console.WriteLine(s1.getdetails());

//        }


//    }
//}
///*there is no inheritance in the structures
// * strct  always create parameterised constructor(default values)
// * */