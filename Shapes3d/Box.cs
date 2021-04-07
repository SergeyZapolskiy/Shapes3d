using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes3d
{
    public class Box : Shape
    {

        public Box(double h)
        {
            _h = h;
        
        }
        
        private double _h = 0;

        public double H
        {
            get => _h;
        }

        private double _volumeBegin = 0;

        private List<Shape> _boxContaint = new List<Shape>();

        public List<Shape> BoxContaint
        {
            get => _boxContaint;
        }

        
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
                _boxContaint.Add(shape);
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
