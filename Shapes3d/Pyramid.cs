using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes3d
{
    public class Pyramid : Shape
    {
        public Pyramid(double s, double h)
        {
            _s = s;
            _h = h;
        }

        private double _s = 0;

        public double S
        {
            get => _s;
        }

        private double _h = 0;

        public double H
        {
            get => _h;
        }
        public override double Volume()
        {
            return (S*H/3.0);
        }
    }
}
