using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace doslineas
{
    public partial class Form1 : Form
    {
        Graphics g,ct;
        Bitmap bmp,center;
        static Point  a, b, c, d;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(bmp);
            canvas.Image = bmp;       
        }

        private void BCT_CANVAS_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Sx = (canvas.Width / 2);
            int Sy = (canvas.Height / 2);

            a = new Point(canvas.Width / 2, 0);
            b = new Point(canvas.Width / 2, canvas.Height);
            c = new Point(0, canvas.Height / 2);
            d = new Point(canvas.Width, canvas.Height / 2);
            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, c, d);

            int angle;

            a = new Point(-50, 50);
            b = new Point(50, 50);
            c = new Point(50, -50);
            d = new Point(-50, -50);

            angle = int.Parse(textBox1.Text);

            Render(a, b, angle, Sx, Sy);
            Render(b, c, angle, Sx, Sy);
            Render(c, d, angle, Sx, Sy);
            Render(d, a, angle, Sx, Sy);
        }

        private void button4_Click(object sender, EventArgs e)

        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;

            int Sx = ((screen.Width/2) - canvas.Width);
            int Sy = ((-50+screen.Height/2)- canvas.Height);
            a = new Point(canvas.Width / 2, 0);
            b = new Point(canvas.Width / 2, canvas.Height);
            c = new Point(0, canvas.Height / 2);
            d = new Point(canvas.Width, canvas.Height / 2);
            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, c, d);

            int angle;

            a = new Point(0,0);
            b = new Point(0,100);
            c = new Point(100, 100);
            d = new Point(100, 0);

            angle = int.Parse(textBox1.Text);

            Render(a, b, angle, Sx, Sy);
            Render(b, c, angle, Sx, Sy);
            Render(c, d, angle, Sx, Sy);
            Render(d, a, angle, Sx, Sy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Point(canvas.Width / 2,0);
            b = new Point(canvas.Width / 2, canvas.Height);
            c = new Point(0, canvas.Height/2);
            d = new Point(canvas.Width, canvas.Height/2);
            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, c, d);

            int x=canvas.Width/2;
            int y=canvas.Height/2;

            a = new Point(x, y);
            b = new Point(x,y-100);
            c = new Point(x+100, y-100);
            d = new Point(x+100, y);

            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, b, c);
            g.DrawLine(Pens.Gray, c, d);
            g.DrawLine(Pens.Gray, d, a);

            canvas.Invalidate();

        }


        private void Render(Point a, Point b, int angle, int Sx, int Sy)
        {
            PointF a2, b2;

            a2 = new PointF(Sx + a.X, Sy - a.Y);
            b2 = new PointF(Sx + b.X, Sy - b.Y);
            double degrees = Math.PI * angle / 180.0;

            a2.X = Sx + (float)((a.X * Math.Cos(degrees)) - (a.Y * Math.Sin(degrees)));
            a2.Y = Sy - (float)((a.X * Math.Sin(degrees)) + (a.Y * Math.Cos(degrees)));
            b2.X = Sx + (float)((b.X * Math.Cos(degrees)) - (b.Y * Math.Sin(degrees)));
            b2.Y = Sy - (float)((b.X * Math.Sin(degrees)) + (b.Y * Math.Cos(degrees)));

            g.DrawLine(Pens.White, a2, b2);

            canvas.Refresh();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int Sx = (canvas.Width / 2);
            int Sy = (canvas.Height / 2);

            a = new Point(canvas.Width / 2, 0);
            b = new Point(canvas.Width / 2, canvas.Height);
            c = new Point(0, canvas.Height / 2);
            d = new Point(canvas.Width, canvas.Height / 2);
            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, c, d);

            int angle;

            a = new Point(0,0);
            b = new Point(0, 100);
            c = new Point(100, 100);
            d = new Point(100, 0);

            angle = int.Parse(textBox1.Text);

            Render(a, b, angle, Sx, Sy);
            Render(b, c, angle, Sx, Sy);
            Render(c, d, angle, Sx, Sy);
            Render(d, a, angle, Sx, Sy);

            
        }


    }
}