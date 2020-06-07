using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public class MyRectangle : MyShape
    {
        public MyRectangle(Color drawColor, Color fillColor, Rectangle rectangle) : base(drawColor, fillColor, rectangle)
        {

        }
        public override double Area()
        {
            return rectangle.Width * rectangle.Height;
        }

        public override int EdgeCount()
        {
            return 4;
        }

        public override double Perimeter()
        {
            return rectangle.Width * 2 + rectangle.Height * 2;
        }
    }
}
