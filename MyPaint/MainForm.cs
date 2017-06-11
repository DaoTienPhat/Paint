using MyPaint.ShapeUtils;
using Paint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen mPen = new Pen(Color.Black, (float)Thickness.normal);
        private Point start = new Point(0, 0);
        private Point end = new Point(0, 0);
        private Point current = new Point(0, 0);
        private bool drawing;
        ContextMenu mContextMenu;
        private String pictureName = "Untitle-1.jpeg";

        private List<Shape> shape = new List<Shape>();
        private List<Bitmap> mBitmapList = new List<Bitmap>();
        private Status state;
        private Color lineColor;
        private List<String> cbPaintBucketStateList;
        TextBox tb = new TextBox();
        private bool saveState = false;
        public PaintEventArgs PEA;
        private static int bitmapWidth = 916;
        private static int bitmapHeight = 507;

        public enum Thickness
        {
            normal = 1,
            third = 3,
            fifth = 5,
            seventh = 7,
        }

        public enum Status
        {
            Pencil,
            Brush,
            Line,
            Ellipse,
            Rectangle,
            Square,
            Circle,
            PaintBucketSolid,
            PaintBucketGradient,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            state = Status.Pencil;
            panelColor1.BackColor = Color.AliceBlue;

            declareShapeClick();
            declareThicknessClick();
            declareShapeMouseHover();
            declareCanvasMouseEvent();
            declareContextMenu();

            this.Controls.Add(tb);
            this.KeyPress += pbCanvas_KeyDown;

            createImage();

            mBitmapList.Add(new Bitmap(pbCanvas.Image));
            g = Graphics.FromImage(mBitmapList[0]);

            colorPickEdit1.Color = Color.Black;
            lineColor = colorPickEdit1.Color;
            colorPickEdit2.Color = Color.White;

            cbPaintBuketState.Items.Add("Solid  Color");
            cbPaintBuketState.Items.Add("Linear Gradient Color");
            cbPaintBuketState.SelectedIndex = 0;

        }

        //tạo sự kiện rê chuột qua nút
        private void declareShapeMouseHover()
        {
            btDrawPencil.MouseHover += showDetail;
            btDrawCircle.MouseHover += showDetail;
            btDrawLine.MouseHover += showDetail;
            btDrawEllipse.MouseHover += showDetail;
            btDrawRectangle.MouseHover += showDetail;
            btDrawSquare.MouseHover += showDetail;
            btPaintBucket.MouseHover += showDetail;
        }
        private void declareShapeClick()
        {
            btDrawCircle.Click += shapeOptionClick;
            btDrawSquare.Click += shapeOptionClick;
            btDrawRectangle.Click += shapeOptionClick;
            btDrawEllipse.Click += shapeOptionClick;
            btDrawLine.Click += shapeOptionClick;
            btDrawPencil.Click += shapeOptionClick;
            btPaintBucket.Click += shapeOptionClick;
        }

        // chọn độ dày
        private void declareThicknessClick()
        {
            btThickness1.Click += chooseThickness;
            btThickness3.Click += chooseThickness;
            btThickness5.Click += chooseThickness;
            btThickness7.Click += chooseThickness;
        }
        
        //tạo sự kiện chuột tại canvas
        private void declareCanvasMouseEvent()
        {
            pbCanvas.MouseDown += pbCanvas_MouseDown;
            pbCanvas.Paint += pbCanvas_Paint;
            pbCanvas.MouseMove += pbCanvas_MouseMove;
            pbCanvas.MouseUp += pbCanvas_MouseUp;
        }

        //tạo context menu
        private void declareContextMenu()
        {
            mContextMenu = new ContextMenu();
            mContextMenu.MenuItems.Add("Open", new EventHandler(openToolStripMenuItem_Click));
            mContextMenu.MenuItems.Add("Save", new EventHandler(saveToolStripMenuItem_Click));
            mContextMenu.MenuItems.Add("Undo");
            pbCanvas.ContextMenu = mContextMenu;
        }

        // nhấn chuột pbCanvas
        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            end = e.Location;
            current = e.Location;    
            drawing = true;
            lineColor = colorPickEdit1.Color;
            mPen.Color = lineColor;

            mBitmapList.Add(new Bitmap(pbCanvas.Image));
            g = Graphics.FromImage(mBitmapList[mBitmapList.Count - 1]);

            if (!e.Button.Equals(MouseButtons.Left))
                return;
            else
            {
                switch (state)
                {
                    case Status.Line:
                        {
                            shape.Add(new LineShape(mPen, start, end));
                            break;
                        }
                    case Status.Rectangle:
                        {
                            shape.Add(new RectangleShape(mPen, start, end));
                            break;
                        }
                    case Status.Square:
                        {
                            shape.Add(new SquareShape(mPen, start, end));
                            break;
                        }
                    case Status.Ellipse:
                        {
                            shape.Add(new EllipseShape(mPen, start, end));
                            break;
                        }
                    case Status.Circle:
                        {
                            shape.Add(new CircleShape(mPen, start, end));
                            break;
                        }
                    case Status.PaintBucketSolid:
                        {
                            //fillTheShape(e.Location);
                            break;
                        }
                    case Status.PaintBucketGradient:
                        {
                            break;
                        }
                    default:
                        {
                            shape.Add(new PencilShape(current));
                            break;
                        }
                }
            }
        }

        public void fillTheShape(Point e)
        {
            Color cl = getPixelColor(e.X, e.Y);

            mBitmapList.Add(new Bitmap(pbCanvas.Image));
            Bitmap bmp = mBitmapList[mBitmapList.Count - 1];

            FloodFill(bmp,
                e,
                bmp.GetPixel(e.X, e.Y),
                colorPickEdit1.Color);

            pbCanvas.Image = bmp;
            pbCanvas.Invalidate();
        }
        // nhả chuột pbCanvas
        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing && e.Button.Equals(MouseButtons.Left))
            {
                
                if (state != Status.PaintBucketGradient && state != Status.PaintBucketSolid)
                {
                    shape[shape.Count - 1].draw(mPen, start, end, g);
                    pbCanvas.Image = mBitmapList[mBitmapList.Count - 1];
                }
                else if(state == Status.PaintBucketSolid)
                {
                    fillTheShape(e.Location);
                }
                drawing = false;
                
                if(mBitmapList.Count > 5)
                {
                    mBitmapList.RemoveAt(0);
                }
               
            }
            pbCanvas.Image = mBitmapList[mBitmapList.Count - 1];
            pbCanvas.Invalidate();
            
        }

        // di chuyển chuột trong pbCanvas
        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {   
            if (drawing && !e.Button.Equals(MouseButtons.Right))
            {
                current = e.Location;
                end = e.Location;
                pbCanvas.Invalidate();
            }
        }

        // vẽ pbCanvas
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            //PEA = e;
            //g = e.Graphics;
            //createImage();                                 

            if (shape.Count > 0)
            {
                
                if (drawing)
                {
                    if (state != Status.PaintBucketSolid)
                    {
                        shape[shape.Count - 1].draw(mPen, start, end, 
                            e.Graphics);                        
                    }
                }                
                
            }
        }

        // tạo ảnh mặc định cho PictureBox pbCanvas
        public void createImage()
        {
            if (pbCanvas.Image == null)
            {
                Bitmap bmp = new Bitmap(bitmapWidth, bitmapHeight);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                }
                pbCanvas.Image = bmp;
                pbCanvas.Invalidate();
            }
            else
            {
                if (mBitmapList.Count > 0)
                {
                    
                    //pbCanvas.Image = new Bitmap(mBitmapList[mBitmapList.Count - 1]);
                    //g = Graphics.FromImage(pbCanvas.Image);
                    pbCanvas.Invalidate();
                }
            }            
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        public Color getPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
        ///////////

        //tìm màu trùng nhau
        public bool ColorMatch(Color a, Color b)
        {
            if (a.ToArgb().ToString().Equals(b.ToArgb().ToString()))
            {
                return true;
            }
            else return false;
            //return (a.ToArgb() & 0xffffff) == (b.ToArgb() & 0xffffff);
        }

        public void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Queue<Point> q = new Queue<Point>();
           
            q.Enqueue(pt);
            while (q.Count > 0)
            {
                Point n = q.Dequeue();

                Color pixelColor = bmp.GetPixel(n.X, n.Y);

                bool check = ColorMatch(bmp.GetPixel(n.X, n.Y), targetColor);
                if (!ColorMatch(bmp.GetPixel(n.X, n.Y), targetColor))
                    continue;
                Point w = n, e = new Point(n.X + 1, n.Y);
                while ((w.X >= 0) && ColorMatch(bmp.GetPixel(w.X, w.Y), targetColor))
                {
                    bmp.SetPixel(w.X, w.Y, replacementColor);
                    if ((w.Y > 0) && ColorMatch(bmp.GetPixel(w.X, w.Y - 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y - 1));
                    if ((w.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(w.X, w.Y + 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y + 1));
                    w.X--;
                }
                while ((e.X <= bmp.Width - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y), targetColor))
                {
                    bmp.SetPixel(e.X, e.Y, replacementColor);
                    if ((e.Y > 0) && ColorMatch(bmp.GetPixel(e.X, e.Y - 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y - 1));
                    if ((e.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y + 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y + 1));
                    e.X++;
                }
            }
            q.GetEnumerator().Dispose();
            return;
        }
        ///////////////////
        // envent click cho các shape
        private void shapeOptionClick(object sender, EventArgs e)
        {
            if (sender.Equals(btDrawPencil))
            {
                state = Status.Pencil;
                return;
            }
            if (sender.Equals(btDrawCircle))
            {
                state = Status.Circle;
                return;
            }
            if (sender.Equals(btDrawEllipse))
            {
                state = Status.Ellipse;
                return;
            }
            if (sender.Equals(btDrawRectangle))
            {
                state = Status.Rectangle;
                return;
            }
            if (sender.Equals(btDrawSquare))
            {
                state = Status.Square;
                return;
            }
            if (sender.Equals(btDrawLine))
            {
                state = Status.Line;
                return;
            }
            if (sender.Equals(btPaintBucket))
            {
                if (cbPaintBuketState.SelectedItem.ToString() == "Linear Gradient Color")
                {
                    state = Status.PaintBucketGradient;
                }
                else state = Status.PaintBucketSolid;

                return;
            }
            if (sender.Equals(btSelectRange))
            {
                state = Status.Rectangle;
                return;
            }
        }

        // chọn độ dày của mPen
        private void chooseThickness(object sender, EventArgs e)
        {
            if (sender.Equals(btThickness1))
            {
                mPen = new Pen(Color.Black, 1);

                return;
            }
            if (sender.Equals(btThickness3))
            {
                mPen = new Pen(Color.Black, 3);
                return;
            }
            if (sender.Equals(btThickness5))
            {
                mPen = new Pen(Color.Black, 5);
                return;
            }
            if (sender.Equals(btThickness7))
            {
                mPen = new Pen(Color.Black, 7);
                return;
            }
        }

        private void showDetail(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            if (sender.Equals(btDrawRectangle))
            {
                ToolTip1.SetToolTip(btDrawRectangle, "Rectangle");
                return;
            }
            if (sender.Equals(btDrawSquare))
            {
                ToolTip1.SetToolTip(btDrawSquare, "Square");
                return;
            }
            if (sender.Equals(btDrawEllipse))
            {
                ToolTip1.SetToolTip(btDrawEllipse, "Ellipse");
                return;
            }
            if (sender.Equals(btDrawCircle))
            {
                ToolTip1.SetToolTip(btDrawCircle, "Circle");
                return;
            }
            if (sender.Equals(btDrawLine))
            {
                ToolTip1.SetToolTip(btDrawLine, "Line");
                return;
            }
            if (sender.Equals(btDrawPencil))
            {
                ToolTip1.SetToolTip(btDrawLine, "Pencil");
                return;
            }
            if (sender.Equals(btPaintBucket))
            {
                ToolTip1.SetToolTip(btDrawLine, "Paint Bucket");
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private bool saveImage()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPEG files (*.jpeg)|*.jpeg"
                + "|PNG files (*.png)|*.png"
                + "|Bitmap files (*.bmp)|*.bmp"
                + "|Gif files (*.gif)|*.gif"
                + "|All files (*.*)|*.*";
            dialog.FileName = pictureName;
            dialog.FilterIndex = 5;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && !dialog.FileName.Equals(""))
            {
                pbCanvas.Image.Save(dialog.FileName);
            }
            return true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG files (*.jpeg)|*.jpeg"
                + "|PNG files (*.png)|*.png"
                + "|Bitmap files (*.bmp)|*.bmp"
                + "|Gif files (*.gif)|*.gif"
                + "|All files (*.*)|*.*";
            dialog.FilterIndex = 5;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK && !dialog.FileName.Equals(""))
            {
                pictureName = dialog.FileName;
                Image i = Image.FromFile(dialog.FileName);

                mBitmapList.Add(new Bitmap(i));
                pbCanvas.Image = mBitmapList[mBitmapList.Count -1];
                pbCanvas.Width = i.Width;
                pbCanvas.Height = i.Height;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape.Clear();
            pbCanvas.Image = new Bitmap(bitmapWidth, bitmapHeight);
            pbCanvas.Invalidate();
        }

        private void pbCanvas_KeyDown(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char) Keys.Z))
            {
                MessageBox.Show("Ctrl + Z");
            }
        }

        //Exit menu thoát chương trình
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveState.Equals(false))
            {
                var result = MessageBox.Show("Save change to this image?"
                    , "Wanrning"
                    , MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.OK:
                        {
                            saveImage();
                            break;
                        }
                    default: break;
                }
            }
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mBitmapList.Count > 1)
            {
                mBitmapList.RemoveAt(mBitmapList.Count - 1);
                pbCanvas.Image = mBitmapList[mBitmapList.Count - 1];

            }
        }
    }
}
