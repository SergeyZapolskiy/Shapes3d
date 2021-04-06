using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes3d
{
    public class Cylinder : Shape
    {

        public Cylinder(double r, double h)
        {
            _r = r;
            _h = h;
        }
        
        private double _r = 0;

        public double R
        {
            get => _r;
        }

        private double _h = 0;

        public double H
        {
            get => _h;
        }
        public override double Volume()
        {
            return (Math.PI*H*R*R);
        }
    }
}
