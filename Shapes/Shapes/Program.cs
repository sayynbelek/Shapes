﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Polymorphism *****/n");
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            ((Circle)o).Draw();
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),
                new Circle("Beth"), new Hexagon("Linda") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();
        }
    }
}
