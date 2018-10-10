
/*
// arry creation


using System;
using System.Collections.Generic;
using System.Text;

namespace training_1
{
    class Class2
    {
        static void Main(string[] args)
        {


            int[] ary = new int[10];
            int[] ary2;
            ary2 = new int[12];

            int[] ary3 = { 11, 22, 33, 44, 55 };

            int[] ary3 = new int[]{ 11, 22, 33, 44, 55 };
            




        }
        

public static double[] GetRoots(int[] numbers)// this will return two array(because of [])
        {
            double[] rootArray = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                rootArray[i] = Math.Sqrt(numbers[i]);
            }
            return rootArray;




        }

        static void Main(string[] args)
        {
            int[] numbers;
            int size;
            Console.WriteLine("enter the size");
            size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];
            Console.WriteLine("enter{0} number:", size);
            for(int i = 0;i <size;i++)

            {
                numbers[i]= Convert.ToInt32(Console.ReadLine());
                }

            double[] roots = Class2.GetRoots(numbers);
            Console.WriteLine("roots are");
            for(int i=0;i<roots.Length; i++)
            {
                Console.WriteLine(roots[i]);
            }
          
















           
        }
    }








}
*/