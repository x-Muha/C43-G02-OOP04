using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Rectangle
    {
        public int W {  get; set; }
        public int H { get; set; }
        public Rectangle()
        {
            W = 0;
            H = 0;
        }
        public Rectangle(int w, int h)
        {
            H = h; 
            W = w;
        }
        public Rectangle(int x)
        {
            W = x;
            H = x;
        }
    }
}
