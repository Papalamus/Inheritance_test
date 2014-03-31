using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Training.Graphic;

namespace WindowsFormsApplication1.OOP_Training.Graphic
{
    class Rectangle : Figure
    {
        private Point _position;

        public Rectangle(int width, int height, Point position) : base(width, height)
        {
            Position = position;
        }

        public Rectangle(int width, int height, Pen pen, Point position) : base(width, height, pen,position)
        {
            Position = position;
        }

        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            Size s = new Size(Width,Height);
            g.DrawRectangle(Pen,new System.Drawing.Rectangle(Position,s));
        }
    }
}
