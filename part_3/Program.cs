Point point1, point2, point3, point4, point5;
point1 = new Point(0, 0); point2 = new Point(0, 2); point3 = new Point(2, 2); point4 = new Point(2, 0); point5 = new Point(1, 3);
Figure triagle = new Figure("Треугольник", point1, point2, point3);
Figure square = new Figure("Квадрат", point1, point2, point3, point4);
Figure domik = new Figure("Домик", point1, point2, point3, point4, point5);

triagle.PerimeterCalculator();
square.PerimeterCalculator();
domik.PerimeterCalculator();

class Point
{
    private int x, y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Figure
{
    private Point p1, p2, p3;
    private Point? p4, p5;
    private string name;
    public Figure(string name, Point p1, Point p2, Point p3)
    {
        this.name = name;
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    public Figure(string name, Point p1, Point p2, Point p3, Point p4) : this(name, p1, p2, p3)
    {
        this.p4 = p4;
    }
    public Figure(string name, Point p1, Point p2, Point p3, Point p4, Point p5) : this(name, p1, p2, p3, p4)
    {
        this.p5 = p5;
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt( Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) );
    }

    public void PerimeterCalculator()
    {
        double res;
        if (p4 == null && p5 == null) 
        {
            res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
        }
        else if (p5 == null)
        {
            res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
        }
        else
        {
            res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
        }
        Console.WriteLine($"Периметр фигуры {name} равен {res:##.##}");
    }
}