using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Point = System.Drawing.Point;

namespace Class
{
    [Serializable]
    public abstract class Figure
    {
        protected Point point1, point2;
        protected Color LineColor, BackgroundColor;
        protected float LineWidth;

        public Figure(Point point1, Point point2, Color color, Color background, float width)
        {
            this.point1 = point1;
            this.point2 = point2;
            LineColor = color;
            LineWidth = width;
            BackgroundColor = background;
        }

        public abstract void Draw(Graphics g);
        public abstract void DrawDash(Graphics g);
        public abstract void Hide(Graphics g);

        public void norm(ref Point startPoint, ref Point endPoint)
        {
           
            int xmin = Math.Min(startPoint.X, endPoint.X);
            int xmax = Math.Max(startPoint.X, endPoint.X);
            int ymin = Math.Min(startPoint.Y, endPoint.Y);
            int ymax = Math.Max(startPoint.Y, endPoint.Y);
           
            startPoint = new Point(xmin, ymin);
            endPoint = new Point(xmax, ymax);
        }
    }
    

    [Serializable]
    public class Rect : Figure
    {
        
        [NonSerialized] public Point startPoint, endPoint;
        public Rect(Point point1, Point point2, Color color, Color background, float width) : base(point1, point2, color, background, width)
        { }

        public void MouseMove(Point point2)
        {
            this.point2 = point2;
        }
        
        public override void Draw(Graphics g)
        {
            norm(ref point1, ref point2);
            g.FillRectangle(new SolidBrush(BackgroundColor), Rectangle.FromLTRB(point1.X, point1.Y, point2.X, point2.Y));
            g.DrawRectangle(new Pen(LineColor, LineWidth), Rectangle.FromLTRB(point1.X, point1.Y, point2.X, point2.Y));
        }
        public override void DrawDash(Graphics g)
        {
            startPoint = point1;
            endPoint = point2;
            norm(ref startPoint, ref endPoint);

            Pen pen1 = new Pen(LineColor, LineWidth);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(pen1, Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
        }
        public override void Hide(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.White, LineWidth), Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
        }
    }
}