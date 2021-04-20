using System.Drawing;


public abstract class Figure
{
        Point point1, point2;
    
        public Figure(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public abstract void Draw(Graphics g);
        public abstract void DrawDash(Graphics g);
        public abstract void Hide(Graphics g);
}

public class Rect : Figure
{
        public Rect(Point point1, Point point2) : base(point1, point2) { }


        public override void Draw(Graphics g)
        {

        }
        public override void DrawDash(Graphics g)
        {

        }
        public override void Hide(Graphics g)
        {

        }


}

