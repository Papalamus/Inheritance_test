using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.OOP_Training.Graphic
{
    class Circle : Ring
    {
        private Brush _brush;


        public Circle(int radius, Point center, Brush b) : base(radius, center)
        {
            this.FillBrush = b;
        }

        public Brush FillBrush
        {
            get { return _brush; }
            set { _brush = value; }
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            g.FillEllipse(FillBrush,GetRectangleArea());
        }
    }
}
