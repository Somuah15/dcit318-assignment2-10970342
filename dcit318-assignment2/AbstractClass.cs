using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class AbstractClassDemo
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(5);
        Rectangle myRectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {myCircle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {myRectangle.GetArea()}");
    }
}
