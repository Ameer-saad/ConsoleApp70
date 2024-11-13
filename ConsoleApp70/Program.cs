using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp69
{
    internal class Rectangle
    {
        int Length, Width;
        public Rectangle()
        {
            Length = 3; Width = 4;
        }
        public Rectangle(int l, int w)
        {
            Length = l; Width = w;
        }
        public int area()
        {
            return (Length * Width);
        }
        public int Perimeter()
        {
            return (2 * (Length + Width));
        }
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle();
         
            Console.WriteLine("the area of rec 1 is : " + rec1.area());
            Console.WriteLine("the Perimeter of rec 1 is : " + rec1.Perimeter());
            Console.WriteLine();
          
            
          Rectangle  rec2 = new Rectangle(6, 9);
           
         
            Console.WriteLine();
            Console.WriteLine("the area of rec 2 is : " + rec2.area());
            Console.WriteLine("the Perimeter of rec 2 is : " + rec2.Perimeter());
        }
    }
}