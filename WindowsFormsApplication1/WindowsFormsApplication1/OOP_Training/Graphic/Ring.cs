using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Training.Graphic;

namespace WindowsFormsApplication1.OOP_Training.Graphic
{
    class Ring : Figure
    {
        private  int _radius;
        private Point _center;

        public Ring(int radius, Point center)
            : base(radius * 2, radius * 2)
        {
            Radius = radius;
            Center = center;
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Point Center
        {
            get { return _center; }
            set { _center = value; }
        }

        protected System.Drawing.Rectangle GetRectangleArea()
        {
            Point p = new Point(Center.X - Radius, Center.Y - Radius);
            Size s = new Size(Radius * 2, Radius * 2);
            return new System.Drawing.Rectangle(p, s);            
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.DrawEllipse(Pen,GetRectangleArea());
        }
    }
}
