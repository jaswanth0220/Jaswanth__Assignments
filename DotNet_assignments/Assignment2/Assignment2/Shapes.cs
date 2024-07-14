using System;

namespace Assignment2
{
    internal class Shapes
    {
        
        public void Area(int length, int width)
        {
            Console.WriteLine("Area of rectangle is " + (length * width));
        }

        
        public void Area(int dummy, int triangleBase, int height)
        {
            Console.WriteLine("Area of triangle is " + (0.5 * triangleBase * height));
        }

        
        public void Area(float radius)
        {
            Console.WriteLine("Area of circle is " + (Math.PI * radius * radius));
        }

        
        public void AreaSquare(int side)
        {
            Console.WriteLine("Area of square is " + (side * side));
        }

        static void Main()
        {
            Shapes shape = new Shapes();
            shape.Area(4, 5); 
            shape.Area(0, 4, 5); 
            shape.Area(3.5f); 
            shape.AreaSquare(4); 
        }
    }
}
