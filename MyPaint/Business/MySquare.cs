using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public class MySquare : MyShape
    {
        public MySquare(Color drawColor, Color fillColor, Rectangle rectangle) : base(drawColor, fillColor, rectangle)
        {
                
        }
        public override double Area()
        {
            return rectangle.Width * rectangle.Width;
        }

        public override int EdgeCount()
        {
            return 4;
        }

        public override double Perimeter()
        {
            return 4 * rectangle.Width;
        }
    }
}
