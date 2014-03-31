using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Training.Graphic;

namespace WindowsFormsApplication1.OOP_Training.Graphic
{
    class Editor
    {
        private List<Figure> figures;
        private Size edge;

        private const int minRange = 30;
        private const int maxRange = 100;

        private const int minLength = 10;
        private const int maxLength = 100;



        public Editor(Size edge)
        {
            this.edge = edge;
            this.Figures = new List<Figure>();
        }

        public void Clean()
        {
            figures.Clear();
        }

        public List<Figure> Figures
        {
            get { return figures; }
            set { figures = value; }
        }

        public Size Edge
        {
            get { return edge; }
            set { edge = value; }
        }

        public void DrawFigures(Graphics g)
        {
            foreach (var figure in Figures)
            {
                figure.Draw(g);
            }
        }


        public void addCircle()
        {
            Random r = new Random();
            int radius = r.Next(minRange, maxRange);
            Point center = new Point(radius + r.Next(0, edge.Width - radius), radius + r.Next(0, edge.Height - radius));
            figures.Add(new Circle(radius,center,Brushes.Chocolate));
        }

        public void addRing()
        {
            Random r = new Random();
            int radius = r.Next(minRange, maxRange);
            Point center = new Point(radius + r.Next(0, edge.Width - radius), radius + r.Next(0, edge.Height - radius));
            figures.Add(new Ring(radius,center));
        }

        public void addRectangle()
        {
            Random r = new Random();
            figures.Add(new Rectangle(r.Next(minLength, maxLength), r.Next(minLength, maxLength), new Point(r.Next(2, 500), r.Next(2, 500))));
        }

        public void addLine()
        {
            Random r = new Random();
            figures.Add(new Line(new Point(r.Next(3, edge.Width), r.Next(3, edge.Height)), new Point(r.Next(3, edge.Width), r.Next(3, edge.Height))));
        }

    }
}
