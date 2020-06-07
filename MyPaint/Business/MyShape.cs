using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public abstract class MyShape
    {
        public Color drawColor;
        public Color fillColor;
        public Rectangle rectangle;

        public MyShape(Color drawColor, Color fillColor, Rectangle rectangle)
        {
            this.drawColor = drawColor;
            this.fillColor = fillColor;
            this.rectangle = rectangle;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract int EdgeCount();
    }
}
