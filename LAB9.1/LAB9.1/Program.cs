Console.Write("Введите координату x: ");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
double y = double.Parse(Console.ReadLine()!);
Perimetr perimetr = new Perimetr(x,y);
perimetr.Print();
class Perimetr
{
    private double X;
    private double Y;
    public Perimetr(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public double getX() { return X; }
    public double getY() { return Y; }
    public double getP()
    {
        return 2*X + 2*Y;
    }
    public void Print()
    {
        Console.WriteLine($"Периметр прямоугольника: {getP()}");
    } 
}