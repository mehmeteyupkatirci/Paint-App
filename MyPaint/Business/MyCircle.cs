using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public class MyCircle : MyShape
    {
        public MyCircle(Color drawColor, Color fillColor, Rectangle rectangle) : base(drawColor, fillColor, rectangle)
        {

        }
        public override double Area()
        {
            return Math.PI * GetRadius()* GetRadius();
        }

        public override int EdgeCount()
        {
            return 0;
        }

        public override double Perimeter()
        {
            return Math.PI* 2 * GetRadius();
        }
        private double GetRadius()
        {
            return rectangle.Width / 2;
        }
    }
}
