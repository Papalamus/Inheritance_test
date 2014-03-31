using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Training.Graphic;

namespace WindowsFormsApplication1.OOP_Training.Graphic
{
    class Line: Figure
    {
        private Point _begin;
        private Point _end;

        public Line(Point begin, Point end):base(-1,-1)
        {
            _begin = begin;
            _end = end;
        }

        public Point Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }

        public Point End
        {
            
            get { return _end; }
            set { _end = value; }
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen,Begin,End);
        }
    }
}
