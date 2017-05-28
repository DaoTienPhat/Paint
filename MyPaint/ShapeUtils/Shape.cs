using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    abstract class Shape
    {
        public abstract void draw();
        public abstract void draw(Graphics g);
        public abstract void draw(PaintEventArgs e);
        public abstract void draw(Pen p, Graphics g);
        public abstract void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e);
        public abstract void draw(Pen p, Point startPoint, Point endPoint, Graphics g);
        public abstract void fillColor(Color color);
        public abstract void fillColor(Color x, Color y);
        public abstract void add(Pen p, Point starPoint, Point endPoint, Graphics g);
    }
    

}
