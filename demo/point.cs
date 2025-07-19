using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal struct Point
    {
        public int X;
        public int Y;

        //public int X = default;
        //public int Y = default; this is fun of CLR


        // constarctor : special Methods
        //              1. Named Like Struct
        //              2. Has No Return Type

        //CLR : Will Generate Parameterless Constructor
        //this constractor will intialized The Attributes with the default

        // constractor
        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }


        public void printPoint()
        {
            Console.WriteLine($"({X} , {Y})");
        }

        public override string ToString()
        {
            return " Hamada";
        }

    }
}
