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
        protected Point point1, point2;             //основные координаты фигуры
        [NonSerialized] public Point startPoint, endPoint;
        protected Color LineColor, BackgroundColor; //Поля для цвета линии и фона
        protected float LineWidth;                  //Поле для толщины линии

        protected bool IsScrolling = false;

        public bool IsFilling { get; set; }         //Поле флага заливки
        public Figure(Point point1, Point point2, Color color, Color background, float width)
        {
            this.point1 = point1;
            this.point2 = point2;
            LineColor = color;
            LineWidth = width;
            BackgroundColor = background;
        }

        public abstract void Draw(Graphics g, Point ScrollShift);
        public abstract void DrawDash(Graphics g, Point ScrollShift);
        public abstract void Hide(Graphics g);

        //Обновление следующей точки
        public void MouseMove(Point point2)
        {
            this.point2 = point2;
        }
        //Нормализация координат
        public void norm(ref Point startPoint, ref Point endPoint)
        {
           
            int xmin = Math.Min(startPoint.X, endPoint.X);
            int xmax = Math.Max(startPoint.X, endPoint.X);
            int ymin = Math.Min(startPoint.Y, endPoint.Y);
            int ymax = Math.Max(startPoint.Y, endPoint.Y);
           
            startPoint = new Point(xmin, ymin);
            endPoint = new Point(xmax, ymax);
        }

        protected void ScrollCalibaration(Point ScrollShift)
        {
            if (!IsScrolling)
            {
                point1.X -= ScrollShift.X;
                point1.Y -= ScrollShift.Y;
                point2.X -= ScrollShift.X;
                point2.Y -= ScrollShift.Y;

                IsScrolling = true;
            }
        }
    }
    
    //Прямоугольник
    [Serializable]
    public class Rect : Figure
    {               
        public Rect(Point point1, Point point2, Color color, Color background, float width) : base(point1, point2, color, background, width)
        { }

        //Рисование окончательного контура фигуры
        public override void Draw(Graphics g, Point ScrollShift)
        {
            //Калибровка координат относительно позиции скрола
            ScrollCalibaration(ScrollShift);
            //Нормализация координат 
            norm(ref point1, ref point2);

            Point DrawPoint1 = new Point(point1.X, point1.Y);
            Point DrawPoint2 = new Point(point2.X, point2.Y);

            if (IsFilling)
            {
                g.FillRectangle(new SolidBrush(BackgroundColor),
                Rectangle.FromLTRB(point1.X + ScrollShift.X, point1.Y + ScrollShift.Y, point2.X + ScrollShift.X, point2.Y + ScrollShift.Y));
            }
            g.DrawRectangle(new Pen(LineColor, LineWidth), 
                Rectangle.FromLTRB(point1.X + ScrollShift.X, point1.Y + ScrollShift.Y, point2.X + ScrollShift.X, point2.Y + ScrollShift.Y));
            
        }
        //Рисование штрихованного контура фигуры
        public override void DrawDash(Graphics g, Point ScrollShift)
        {
            startPoint = point1;
            endPoint = point2;

            norm(ref startPoint, ref endPoint);

            Pen pen1 = new Pen(LineColor, LineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawRectangle(pen1, Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
 
        }
        //Стирание предыдущих контуров
        public override void Hide(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.White, LineWidth), Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
        }
       
    }
    //Класс эллипса
    [Serializable]
    public class Ellipse : Figure
    {
        public Ellipse(Point point1, Point point2, Color color, Color background, float width) 
            : base(point1, point2, color, background, width)
        { }
        public override void DrawDash(Graphics g, Point ScrollShift)
        {
            startPoint = point1;
            endPoint = point2;
            norm(ref startPoint, ref endPoint);

            Pen pen1 = new Pen(LineColor, LineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawEllipse(pen1, Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
        }
        public override void Draw(Graphics g, Point ScrollShift)
        {
            //Нормализация координат 
            ScrollCalibaration(ScrollShift);
            norm(ref point1, ref point2);
            if (IsFilling)
            {
                g.FillEllipse(new SolidBrush(BackgroundColor),
                Rectangle.FromLTRB(point1.X + ScrollShift.X, point1.Y + ScrollShift.Y, point2.X + ScrollShift.X, point2.Y + ScrollShift.Y));
            }

                g.DrawEllipse(new Pen(LineColor, LineWidth),
                Rectangle.FromLTRB(point1.X + ScrollShift.X, point1.Y + ScrollShift.Y, point2.X + ScrollShift.X, point2.Y + ScrollShift.Y));
        }
        //Стирание предыдущих контуров
        public override void Hide(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.White, LineWidth), Rectangle.FromLTRB(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y));
        }
    }
    //Класс для прямой линии
    [Serializable]
    public class StraightLine : Figure
    {
        public StraightLine(Point point1, Point point2, Color color, Color background, float width)
            : base(point1, point2, color, background, width)
        { }

        public override void DrawDash(Graphics g, Point ScrollShift)
        {
            startPoint = point1;
            endPoint = point2;

            Pen pen = new Pen(LineColor, LineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }
        public override void Draw(Graphics g, Point ScrollShift)
        {
ScrollCalibaration(ScrollShift);
            g.DrawLine(new Pen(LineColor, LineWidth), point1.X + ScrollShift.X, point1.Y + ScrollShift.Y, point2.X + ScrollShift.X, point2.Y + ScrollShift.Y);
        }
        //Стирание предыдущих контуров
        public override void Hide(Graphics g)
        {
            g.DrawLine(new Pen(Color.White, LineWidth), startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }
    }

    //Кривая линии
    [Serializable]
    public class CurveLine : Figure
    {
        List <Point> Points = new List<Point>();

        public CurveLine(Point point1, Point point2, Color color, Color background, float width)
            : base(point1, point2, color, background, width)
        {
            Points.Add(point1);
            Points.Add(point2);
        }
        //Добавление новых точек для кривой
        public void AddPoint(Point NewPoint)
        {
            Points.Add(NewPoint);
        }
        //Пунктир
        public override void DrawDash(Graphics g, Point ScrollShift)
        {
            startPoint = point1;
            endPoint = point2;

            Points.Add(endPoint);
            g.DrawCurve(new Pen(LineColor, LineWidth), Points.ToArray());

        }
        //Риосование сплошной линией
        public override void Draw(Graphics g, Point ScrollShift)
        {
            if(!IsScrolling)
            {
                for (int i = 0; i < Points.Count; i++)
                    Points[i] = new Point(Points[i].X - ScrollShift.X, Points[i].Y - ScrollShift.Y);
                IsScrolling = true;
            }
            //Новый массив для изменения координат точек
            Point[] Points_With_Scroll = new Point[Points.Count];
            for (int i = 0; i < Points.Count; i++)
            {
                    Points_With_Scroll[i] = new Point(Points[i].X + ScrollShift.X, Points[i].Y + ScrollShift.Y);
            }
            g.DrawCurve(new Pen(LineColor, LineWidth), Points_With_Scroll);
        }
        //Стирание предыдущих контуров
        public override void Hide(Graphics g)
        {

        }
    }

}