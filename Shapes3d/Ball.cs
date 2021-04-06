using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes3d
{
    public class Ball : Shape
    {
        public Ball(double r)
        {
            _r = r;
        }
        
        double _r = 0;

        double R
        {
            get => _r;
        }
        public override double Volume()
        {
            return (4*Math.PI*R*R*R/3);
        }
    }
}
