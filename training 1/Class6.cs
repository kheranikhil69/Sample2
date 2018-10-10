//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace training_1
//{
//    class Employee
//    {
//        protected string Name;
//        protected int code;
//        public Employee()
//        {

//            Name = "no name";
//            code = 0;



//        }
//        public Employee(string Name,int code)
//        {

//            this.Name = Name;
//            this.code = code;


//        }

//        //public void displaydetails()
//        public virtual void displaydetails()// we can  write new behaviour inthe child class or it can be redefined in the child class
//        {

//            Console.WriteLine(Name);
//                Console.WriteLine(code);


//        }
//    }

//    class Manager:Employee //inheritance(no multiple inheritance can be done)
//    {
//        protected float salary;
//        public Manager()
//        {
//            salary = 0;


//        }
//        public Manager(int code,string Name,float salary):base(Name,code)
//        {
//            this.salary = salary;


//        }

//       //public new void displaydetails()//because the child class also have same name function as displaydetails this is calle hiding
//            //forcefull hiding not in an autherised way
//             public override void displaydetails()// by overriding it can be changed 

//        {
//            //base.displaydetails();
//            Console.WriteLine("salary is {0}", salary);
//            Console.WriteLine("name is {0}", Name);
//            Console.WriteLine("code is {0}", code);



//            // parent ka virtual hi override m or child class m change hoga
//        }


//    }
//class MainClass
//    {

//        static void Main(string[] args)
//        {


//            Manager manager = new Manager(120, "john", 2000);


//            //Manager manager = new Manager();
//            manager.displaydetails();
//        }



//    }
//}
 


