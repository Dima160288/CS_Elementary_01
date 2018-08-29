using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace PaintMy
{
    public partial class Form1 : Form
    {
        Pen p;
        GraphicPrimitive primitive;
        public static Color fillColor;      //
        public Form1()
        {
            InitializeComponent();
            primitive = new Pencil(DrawPanel.CreateGraphics());
            p = new Pen(Color.Black, (float)trackBarThickness.Value);
            fillColor = Color.Black;
           // buttonInvert.Click += MakeWork;

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (primitive.isPressed)
            {
                primitive.SetCoordinate(e);
                if (primitive is Pencil)
                    primitive.Draw(p);
            }
            LabelCurrCoordinate.Text = ("X:" +  e.X  +" " +"Y:" +  e.Y);

        }
        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            primitive.isPressed = false;
            if (!(primitive is Pencil))
                primitive.Draw(p);
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            primitive.isPressed = true;
            primitive.CurrentPoint = e.Location;
            primitive.StartPointShape = e.Location;
        }

        private void btnCheckColor_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialogLine.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
                p = new Pen(colorDialogLine.Color, (float)trackBarThickness.Value);
            btnCheckColor.BackColor = colorDialogLine.Color;
            btnCheckColor.ForeColor = Inversion.InvertColor(colorDialogLine.Color);
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialogFill.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
                buttonFillColor.BackColor = colorDialogFill.Color;
            fillColor = colorDialogFill.Color;
            btnCheckColor.ForeColor = Inversion.InvertColor(colorDialogFill.Color);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DrawPanel.Refresh();
        }


        private void radioButtonPencil_CheckedChanged(object sender, EventArgs e)
        {
            primitive = new Pencil(DrawPanel.CreateGraphics());
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            primitive = new Line(DrawPanel.CreateGraphics());
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            primitive = new Rectangle(DrawPanel.CreateGraphics());
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            primitive = new Ellipse(DrawPanel.CreateGraphics());
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            p = new Pen(colorDialogLine.Color, (float)trackBarThickness.Value);
            panelThicknessLine.Refresh();
            Graphics gPanelThickness = panelThicknessLine.CreateGraphics();
            gPanelThickness.DrawLine(p, 20, 10, 85, 10);
            labelThicknessLine.Text = "x" + Convert.ToString(trackBarThickness.Value);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(DrawPanel.Width, DrawPanel.Height);
            Graphics grafics = Graphics.FromImage(bm);
            System.Drawing.Rectangle rect = DrawPanel.RectangleToScreen(DrawPanel.ClientRectangle);
            grafics.CopyFromScreen(rect.Location, Point.Empty, DrawPanel.Size);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png files| *.png| jpeg files| *.jpg| bitmaps| *.bmp";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    if (save.FileName.Contains(".jpg"))
                    {
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                    }
                    else if (save.FileName.Contains(".png"))
                    {
                        bm.Save(save.FileName, ImageFormat.Png);
                    }
                    else if (save.FileName.Contains(".bmp"))
                    {
                        bm.Save(save.FileName, ImageFormat.Bmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Png files| *.png| jpeg files| *jpg| bitmaps| *bmp";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Bitmap pmOp = new Bitmap(open.FileName);
                    //shape.bm = new Bitmap(pmOp.Width, pmOp.Height);
                    //shape.bm = pmOp;
                    //   //Image im = (Image)shape.bm;

                    DrawPanel.Width = pmOp.Width;
                    DrawPanel.Height = pmOp.Height;
                    Graphics graphics;
                    //DrawPanel.BackgroundImage = shape.bm;
                    graphics = DrawPanel.CreateGraphics();
                    //shape.g = Graphics.FromImage(im);
                    graphics.DrawImage(pmOp, 0, 0, pmOp.Width, pmOp.Height);
                    graphics.Dispose();
                    pmOp.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image " + ex.Message);
                }
            }
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
           
         
            Bitmap bm = new Bitmap(DrawPanel.Width, DrawPanel.Height);
            Graphics graphics = Graphics.FromImage(bm);
            System.Drawing.Rectangle rect = DrawPanel.RectangleToScreen(DrawPanel.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, DrawPanel.Size);
            graphics = DrawPanel.CreateGraphics();
            graphics.DrawImage(Inversion.InvertImage(bm), 0, 0, bm.Width, bm.Height);
            bm.Dispose();
            graphics.Dispose();
        }

        void MakeWork(object sender, EventArgs args)
        {
 
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += worker_DoWork;
           // worker.RunWorkerCompleted += (s, a) => label.Text = "Completed";
            worker.ProgressChanged +=
                (s, progressChangedArgs) => ProgressBarImageManipulation.Value = progressChangedArgs.ProgressPercentage;

           // cancelButton.Click += (s, a) => worker.CancelAsync();

            worker.RunWorkerAsync();
        }
        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (((BackgroundWorker)sender).CancellationPending) break;



                ((BackgroundWorker)sender).ReportProgress(i);
            }
        }
    }


    public class Pencil : GraphicPrimitive
    {
        public Point PrevPoint;
        public Pencil(Graphics g)
        {
            this.g = g;
        }


        public override void Draw(Pen p)
        {
            g.DrawLine(p, PrevPoint, CurrentPoint);
        }

        public override void SetCoordinate(MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
            }
        }
    }

    public class Line : GraphicPrimitive
    {
        public Line(Graphics g)
        {
            this.g = g;
        }


        public override void Draw(Pen p)
        {
            g.DrawLine(p, StartPointShape, CurrentPoint);
        }

        public override void SetCoordinate(MouseEventArgs e)
        {
            if (isPressed)
            {
                CurrentPoint = e.Location;
            }
        }
    }

    public class Rectangle : GraphicPrimitive
    {
        public int rectStartPointX;
        public int rectStartPointY;
        public int rectSizeX;
        public int rectSizeY;

        public Rectangle(Graphics g)
        {
            this.g = g;
        }


        public override void Draw(Pen p)
        {
            g.DrawRectangle(p, rectStartPointX, rectStartPointY, rectSizeX, rectSizeY);
            g.FillRectangle(new SolidBrush(Form1.fillColor), rectStartPointX, rectStartPointY, rectSizeX, rectSizeY);
        }

        public override void SetCoordinate(MouseEventArgs e)
        {
            if (isPressed)
            {
                CurrentPoint = e.Location;

                rectStartPointX = Math.Min(StartPointShape.X, e.X);
                rectStartPointY = Math.Min(StartPointShape.Y, e.Y);
                rectSizeX = Math.Max(StartPointShape.X, e.X) - Math.Min(StartPointShape.X, e.X);
                rectSizeY = Math.Max(StartPointShape.Y, e.Y) - Math.Min(StartPointShape.Y, e.Y);
            }
        }
    }

    public class Ellipse : GraphicPrimitive
    {
        public int circleStartPointX;
        public int circleStartPointY;
        public int circleSizeX;
        public int circleSizeY;
        public Ellipse(Graphics g)
        {
            this.g = g;
        }


        public override void Draw(Pen p)
        {
            g.DrawEllipse(p, circleStartPointX, circleStartPointY, circleSizeX, circleSizeY);
            g.FillEllipse(new SolidBrush(Form1.fillColor), circleStartPointX, circleStartPointY, circleSizeX, circleSizeY);
        }

        public override void SetCoordinate(MouseEventArgs e)
        {
            if (isPressed)
            {
                CurrentPoint = e.Location;
                circleStartPointX = Math.Min(StartPointShape.X, e.X);
                circleStartPointY = Math.Min(StartPointShape.Y, e.Y);
                circleSizeX = Math.Max(StartPointShape.X, e.X) - Math.Min(StartPointShape.X, e.X);
                circleSizeY = Math.Max(StartPointShape.Y, e.Y) - Math.Min(StartPointShape.Y, e.Y);

                if (circleSizeX > circleSizeY)
                    circleSizeY = circleSizeX;
                else if (circleSizeX < circleSizeY)
                    circleSizeX = circleSizeY;
            }
        }
    }

    public abstract class GraphicPrimitive
    {
        public Point CurrentPoint;
        public Point StartPointShape;

        public bool isPressed;
        public Graphics g;


        public abstract void Draw(Pen p);
        public abstract void SetCoordinate(MouseEventArgs e);
    }

    public static class Inversion
    {
        public static Color InvertColor(Color c)
        {
            return Color.FromArgb(c.A, 0xFF - c.R, 0xFF - c.G, 0xFF - c.B);
        }

        public static Bitmap InvertImage(Bitmap bm)
        {
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    Color pixel = bm.GetPixel(i, j);
                    //int red = pixel.R;
                    //int green = pixel.G;
                    //int blue = pixel.B;
                    //bm.SetPixel(i, j, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                    bm.SetPixel(i, j, Color.FromArgb(pixel.A, 0xFF - pixel.R, 0xFF - pixel.G, 0xFF - pixel.B));
                }
            }
            return bm;
        }
    }



}

