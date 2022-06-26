using System;

namespace Lab6
{
    class Shape
    {
        abstract class Shape
        {
            public double height;
            public double width;
            public abstract void CalculateSurface();
       
            // {
            //     return 0;
            // }
        }
        class Triangle : Shape
        {
            public override double CalculateSurface()
        {
            return height * width/2;
        }
        }
        class Rectangle : Shape
        {
            public override double CalculateSurface()
            {
                return height * width;
            } 
        }
            class Circle : Shape
            {
                public circle (dobule radius);
                // height = radius;
                // width = radius;
            }
            public override double CalculateSurface()
            {
                return 3.142 * height * width;
                 }
            }       
        public void Main(string[] args)
        {
            Shape shapes = new Shape();
            shapes = new Triangle();
            shapes.height = 3;
            shapes.width = 8;
            
            shapes = new Rectangle ();
            shapes.height = 7;
            shapes.width = 5;

            shapes = new Circle (9);

            for (int i = 0; i < 1; i+1)
            {
                Console.WriteLine(Surface:, shapes.Calculate());
            }
            Console.ReadLine();
        }
    }

