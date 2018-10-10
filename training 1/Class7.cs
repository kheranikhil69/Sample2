using System;
using System.Collections.Generic;
using System.Text;

namespace training_1
{
   //sealed class shape // we cannot inherit sealed class 
        class shape
    {
        public  virtual void Draw()
        {
            Console.WriteLine("shape one");
        }

        class circle : shape
        {
            public override void Draw()
            {
                Console.WriteLine("circle");

            }
        }
        class triangle : shape
        {
            public  override void Draw()
            {
                Console.WriteLine("triangle");
            }
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                shape shape = new circle();
                shape.Draw();
            }


        }

    }









}
