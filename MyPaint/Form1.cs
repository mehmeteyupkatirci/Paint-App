using MyPaint.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public SelectedShape selectedShape;
        ShapeCollector myCollector;
        bool isDrawing;
        bool capacityReached;

        Point firstLocation;
        Point secondLocation;

        public Form1()
        {
            InitializeComponent();
            myCollector = new ShapeCollector();
            myCollector.CapacityFull += onCapacityFull;
            myCollector.CapacityReached += onCapacityReached;
            selectedShape = SelectedShape.none;
            isDrawing = false;
            capacityReached = false;
        }

        public void onCapacityReached()
        {
            rchtPanel.Text = "Kapasiteye Erişildi";
            capacityReached = true;
        }

        public void onCapacityFull()
        {
            rchtPanel.Text = "Kapasite Dolu Ekleyemezsiniz";
            capacityReached = true;
        }
       
        private void btnBorder_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rchtPanel.Text = colorDialog1.Color.ToString() + " Çerçeve Rengi Olarak Seçildi";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            rchtPanel.Text = colorDialog2.Color.ToString() + " Dolgu Rengi Olarak Seçildi";
        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = SelectedShape.square;
            rchtPanel.Text = "Kare Seçildi";
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = SelectedShape.circle;
            rchtPanel.Text = "Daire Seçildi";
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = SelectedShape.rectangle;
            rchtPanel.Text = "Dikdörtgen Seçildi";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedShape == SelectedShape.none||capacityReached) return;

            isDrawing = true;
            firstLocation = e.Location;
            summarizeDrawing(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShape == SelectedShape.none || isDrawing==false || capacityReached) return;
            isDrawing = false;

            secondLocation = e.Location;

            rchtPanel.Text = selectedShape.ToString() + " çizildi";

            MyShape aShape;

            if (selectedShape == SelectedShape.circle)
                aShape = new MyCircle(colorDialog1.Color, colorDialog2.Color, GetRectangle());
            else if (selectedShape == SelectedShape.square)
                aShape = new MySquare(colorDialog1.Color, colorDialog2.Color, GetRectangle());
            else
                aShape = new MyRectangle(colorDialog1.Color, colorDialog2.Color, GetRectangle());
            myCollector.AddShape(aShape);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedShape == SelectedShape.none || isDrawing == false || capacityReached) return;
            secondLocation = e.Location;
            summarizeDrawing(e.Location);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(var aShape in myCollector.GetShapes())
            {
                Pen myPen = new Pen(aShape.drawColor,5);
                SolidBrush myBrush = new SolidBrush(aShape.fillColor);
                Rectangle rect = aShape.rectangle;

                SelectedShape selectedShapeTemp = SelectedShape.circle;
                if (aShape is MySquare)
                    selectedShapeTemp = SelectedShape.square;
                else if (aShape is MyRectangle)
                    selectedShapeTemp = SelectedShape.rectangle;


                drawMyShape(e.Graphics, myPen, myBrush, rect, selectedShapeTemp);
            }

            if(firstLocation != null && secondLocation != null)
            {
                Pen myPen = new Pen(colorDialog1.Color, 5);
                SolidBrush myBrush = new SolidBrush(colorDialog2.Color);

                Rectangle rect = GetRectangle();
                drawMyShape(e.Graphics, myPen, myBrush, rect, selectedShape);
            }

            e.Graphics.Dispose();
                
        }

        private void summarizeDrawing(Point point)
        {
            rchtPanel.Text = selectedShape.ToString() + "| X: " + point.X + " | Y: " + point.Y;
        }

        private void drawMyShape(Graphics g, Pen myPen, SolidBrush myBrush, Rectangle rect, SelectedShape theShape)
        {
            
            if (theShape == SelectedShape.square || theShape == SelectedShape.rectangle)
            {
                g.DrawRectangle(myPen, rect);
                g.FillRectangle(myBrush, rect);
            }
            else
            {
                g.DrawEllipse(myPen, rect);
                g.FillEllipse(myBrush, rect);
            }
            
        }

        private Rectangle GetRectangle()
        {
            int x = Math.Min(firstLocation.X, secondLocation.X);
            int y = Math.Min(firstLocation.Y, secondLocation.Y);

            int width = 0, height = 0;

            if (selectedShape == SelectedShape.circle || selectedShape == SelectedShape.square)
            {
                width = Math.Max(Math.Abs(firstLocation.X - secondLocation.X), Math.Abs(firstLocation.Y - secondLocation.Y));
                height = width;
            }
            else
            {
                width = Math.Abs(firstLocation.X - secondLocation.X);
                height = Math.Abs(firstLocation.Y - secondLocation.Y);
            }

            Rectangle rect = new Rectangle(x, y, width, height);
            return rect;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double totalArea = 0;
            foreach (var item in myCollector.GetShapes())
            {
                totalArea += item.Area();
            }
            rchtPanel.Text = "Toplam alan : " + totalArea;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstLocation.X = 0;
            firstLocation.Y = 0;
            secondLocation.X = 0;
            secondLocation.Y = 0;
            capacityReached = false;
            myCollector.ClearShapes();
            this.Invalidate();
            rchtPanel.Text = "Temizlendi";
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            double totalPerimeter = 0;
            foreach (var item in myCollector.GetShapes())
            {
                totalPerimeter += item.Perimeter();
            }
            rchtPanel.Text = "Toplam Çevre : " + totalPerimeter;
        }
    }

    public enum SelectedShape
    {
        none,
        circle, 
        square,
        rectangle
    }
}
