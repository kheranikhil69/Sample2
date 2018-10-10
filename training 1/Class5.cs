//using System;
//using System.Collections.Generic;
//using System.Text;
//// generating generic type 
//namespace training_1
//{
//    class STACK<T>
//    {
//        T[] container;//array of type T as stack contian T type 
//        int position;
//        public STACK(int size)// constructor
//        {

//            container = new T[size];
//            position = -1;
        

//        }

//        public void Push(T data)
//        {
//            if (position < container.Length - 1)
//            {
//                container[++position] = data;
//            }
//            else
//            {
//                Console.WriteLine("full stack");
//            }


//        }

//        public T Pop()
//        {
//            if (position >= 0)
//            {


//                T data = container[position--];
//                return data;
//            }
//            return default(T);

//        }

//    }

//class MainClass
//    {

//        static void Main(string[] args)
//        {
//            STACK<int> stack = new STACK<int>(3);
//            stack.Push(100);
//            stack.Push(200);
//            stack.Push(300);
//                              //if we will enter one more value the it will display full stack
//stack.Push(400);
//            Console.WriteLine("-----------------");
//            Console.WriteLine(stack.Pop());
//            Console.WriteLine(stack.Pop());
//            Console.WriteLine(stack.Pop());
//            Console.WriteLine(stack.Pop());







//        }


//    }

//}
