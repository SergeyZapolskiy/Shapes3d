using System;
using System.Collections.Generic;

namespace Shapes3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(100);
            Cylinder cylinder = new Cylinder(5, 10);
            Pyramid pyramid = new Pyramid(20, 10);
            Ball ball = new Ball(10);
            List<Shape> containtShape = CicleFigur(box, cylinder, pyramid, ball);
            Console.WriteLine($"{containtShape}");
        }

        static List<Shape> CicleFigur(Box box, Cylinder cylinder, Pyramid pyramid, Ball ball)
        {
            bool b = true;
            while (b)
            {
                bool c1, c2, c3 = true;
                c1 = box.Add(cylinder);
                c2 = box.Add(pyramid);
                c3 = box.Add(ball);
                if (!c1 && !c2 && !c3)
                {
                    b = false;
                }
            }
            return box.BoxContaint;
        }
    }
}
