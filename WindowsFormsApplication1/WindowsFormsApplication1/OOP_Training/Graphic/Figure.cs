using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training.Graphic
{
    public abstract class Figure
    {
        private int _width;
        private int _height;
        private Pen _pen;
        private Point position;

        public Figure(int width, int height):
            this(width,height,new Pen(Color.BlueViolet),new Point(0,0))
        {
        }

        protected Figure(int width, int height, Pen pen, Point position)
        {
            Width = width;
            Height = height;
            Pen = pen;
            this.Position= position;
        }

        public int Width
        {
            get { return _width; }
            set {
                if (value < 0)
                {
                    value = -1;
                }
                
                _width = value; 
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    value = -1;
                } 
                _height = value;
            }
        }

        public Pen Pen
        {
            get { return _pen; }
            set { _pen = value; }
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public abstract void Draw(Graphics g);
    }
}
