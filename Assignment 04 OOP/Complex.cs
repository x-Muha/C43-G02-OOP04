using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real?? 0)+(right?.Real?? 0),
                Img = (left?.Real?? 0)+(right?.Real?? 0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real?? 0)-(right?.Real?? 0),
                Img = (left?.Real?? 0)-(right?.Real?? 0)
            };
        }
    }
}
