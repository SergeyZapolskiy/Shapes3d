using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes3d
{
    public class Box : Shape
    {

        private double _h = 0;

        public double H
        {
            get => _h;
        }

        private double _volumeBegin = 0;

        
        public override double Volume()
        {
            return (H*H*H);
        }

        
        public bool Add(Shape shape)
        {
            bool b = false;
            if (_volumeBegin == 0)
            {
                _volumeBegin = Volume();
            }
            if (shape.Volume() <= _volumeBegin)
            {
                _volumeBegin -= shape.Volume();
                b = true;
            }
            else 
            {
                Console.WriteLine("Fails to put the figure");
                b = false;
            }
            return b;
        }
    }
}
