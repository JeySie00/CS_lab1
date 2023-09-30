Console.Write("Введите длину прямоугольника: ");
double r_side_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите ширину прямоугольника: ");
double r_side_2 = Convert.ToDouble(Console.ReadLine());

Rectangle reg = new Rectangle(r_side_1, r_side_2);


Console.WriteLine($"Площадь прямоугольника: {reg.Area:##.##}\nШирина прямоугольника: {reg.Perimeter:##.##}");


class Rectangle
{
    private double side1, side2;

    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    private double CalculateArea()
    {
        return side1 * side2;
    }

    private double CalculatePerimeter()
    {
        return (side1 + side2) * 2;
    }

    public double Area { get { return CalculateArea(); } }

    public double Perimeter { get { return CalculatePerimeter(); } }

}