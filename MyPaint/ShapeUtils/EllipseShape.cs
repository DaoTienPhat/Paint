﻿using Paint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class EllipseShape: Shape
    {

        private Pen mPen1;
        private Graphics mGraphic;
        private Rectangle mRectangle;
        private Point start;
        private Point end;
        private SolidBrush sb;
        private LinearGradientBrush lgb;

        private int colorFilled = 0;

        protected Pen MPen1
        {
            get
            {
                return mPen1;
            }

            set
            {
                mPen1 = value;
            }
        }

        protected Graphics MGraphic
        {
            get
            {
                return mGraphic;
            }

            set
            {
                mGraphic = value;
            }
        }

        public Rectangle MRectangle
        {
            get
            {
                return mRectangle;
            }

            set
            {
                mRectangle = value;
            }
        }

        public Point Start1
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public Point End1
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public Rectangle getEllipse(Point start, Point end)
        {
            return new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }
        public EllipseShape()
        {
            this.MPen1 = new Pen(Color.Black);
        }

        public EllipseShape(Rectangle rect)
        {
            this.MRectangle = rect;
            this.MPen1 = new Pen(Color.Black);
        }
        public EllipseShape(Pen p, Point startP, Point endP)
        {
            this.Start1 = startP;
            this.End1 = endP;
            this.MPen1 = new Pen(p.Color, p.Width);
        }

        // paint the color for the retangle
        public bool paintColor()
        {
            switch (colorFilled)
            {
                case 1:
                    {
                        mGraphic.FillEllipse(sb, getEllipse(start, end));
                        return true;
                    }
                case 2:
                    {
                        mGraphic.FillEllipse(lgb, getEllipse(start, end));
                        return true;
                    }
                default: break;
            }
            return false;
        }

        public override void draw(PaintEventArgs e)
        {
            this.MGraphic = e.Graphics;
            MGraphic.DrawEllipse(MPen1, getEllipse(Start1, End1));
            paintColor();
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            this.MPen1 = new Pen(p.Color, p.Width);
            e.Graphics.DrawEllipse(p, getEllipse(Start1, End1));
            paintColor();
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(p, getEllipse(startPoint, endPoint));
            Start1 = startPoint;
            End1 = endPoint;
            this.MPen1 = new Pen(p.Color, p.Width);
            paintColor();
        }

        public override void draw()
        {
            if (!this.mRectangle.Equals(null))
            {
                mGraphic.DrawEllipse(mPen1, this.mRectangle);
                paintColor();
            }
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, Graphics g)
        {
            mGraphic = g;
            this.MPen1 = new Pen(p.Color, p.Width);
            Start1 = startPoint;
            End1 = endPoint;
            mGraphic.DrawEllipse(p, getEllipse(startPoint, endPoint));

            //paintColor();
        }

        public override void fillColor(Color color)
        {
            sb = new SolidBrush(color);
            colorFilled = 1;
            mGraphic.FillEllipse(sb, getEllipse(start, end));
        }

        public override void fillColor(Color x, Color y)
        {
            lgb = new LinearGradientBrush(start, end, x, y);
            colorFilled = 2;
            mGraphic.FillEllipse(lgb, getEllipse(start, end));
        }

        public override void add(Pen p, Point starPoint, Point endPoint, Graphics g)
        {
            this.mPen = new Pen(p.Color, p.Width);
            this.start = starPoint;
            this.end = endPoint;
            this.mGraphic = g;
        }
    }
}
