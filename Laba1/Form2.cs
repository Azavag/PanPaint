using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Point = System.Drawing.Point;

using 
namespace Laba1
{
    public partial class Form2 : Form
    {
        Graphics g;
        Point point1, point2;
        Point Newpoint1, Newpoint2;
        bool isMouseDown = false;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMouseDown == false)
            {

                isMouseDown = true;
                point1 = new System.Drawing.Point(e.X, e.Y);

            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            point2 = new Point(e.X, e.Y);

            if (isMouseDown)
            {
                int xmin = Math.Min(point1.X, point2.X);
                int xmax = Math.Max(point1.X, point2.X);
                int ymin = Math.Min(point1.Y, point2.Y);
                int ymax = Math.Max(point1.Y, point2.Y);
                {
                    g.DrawRectangle(new Pen(Color.White, 1), Rectangle.FromLTRB(Newpoint1.X, Newpoint1.Y, Newpoint2.X, Newpoint2.Y));
                    g.DrawRectangle(pen1, Rectangle.FromLTRB(xmin, ymin, xmax, ymax));
                }
                Newpoint1 = new Point(xmin, ymin);
                Newpoint2 = new Point(xmax, ymax);            
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                g.DrawRectangle(new Pen(Color.Black, 1), Rectangle.FromLTRB(Newpoint1.X, Newpoint1.Y, Newpoint2.X, Newpoint2.Y));
                isMouseDown = false;

            }
            
            Newpoint2 = new Point(0,0);
        }
    }
}
