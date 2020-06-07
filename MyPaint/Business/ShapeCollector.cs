using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public delegate void Notify();

    public class ShapeCollector
    {
        public event Notify CapacityReached; //event
        public event Notify CapacityFull; //event

        private List<MyShape> myShapes;
        public ShapeCollector()
        {
            myShapes = new List<MyShape>();
        }
        public void AddShape(MyShape shape)
        {
            if(myShapes.Count >= 20)
            {
                OnCapacityFull();
                return;
            }

            myShapes.Add(shape);
            if (myShapes.Count == 20)
                OnCapacityReached();
        }

        public List<MyShape> GetShapes()
        {
            return myShapes;
        }
        public void ClearShapes()
        {
            myShapes.Clear();
        }
         
        protected virtual void OnCapacityReached()
        {
            CapacityReached?.Invoke();
        }

        protected virtual void OnCapacityFull()
        {
            CapacityFull?.Invoke();
        }
    }
}
