using System;
public class Vector3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3D Add(Vector3D v)
    {
        double newX = X + v.X;
        double newY = Y + v.Y;
        double newZ = Z + v.Z;
        return new Vector3D(newX, newY, newZ);
    }
    public Vector3D Subtract(Vector3D v)
    {
        double newX = X - v.X;
        double newY = Y - v.Y;
        double newZ = Z - v.Z;
        return new Vector3D(newX, newY, newZ);
    }
    public double MultiplyScalar(Vector3D v)
    {
        return X * v.X + Y * v.Y + Z * v.Z;
    }
    public Vector3D MultiplyByScalar(double scalar)
    {
        double newX = X * scalar;
        double newY = Y * scalar;
        double newZ = Z * scalar;
        return new Vector3D(newX, newY, newZ);
    }
    public bool Сomparison(Vector3D v)
    {
        return (X == v.X && Y == v.Y && Z == v.Z);
    }
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }
    public int CompareLength(Vector3D v)
    {
        double len1 = this.Length();
        double len2 = v.Length();
        if (Math.Abs(len1 - len2) < 0.000001)
            return 0;
        else if (len1 < len2)
            return -1;
        else
            return 1;
    }
    public void Display()
    {
        Console.WriteLine($"({X}, {Y}, {Z})");
    }
}

class Program
{
    static void Main()
    {
        Vector3D v1 = new Vector3D(1.0, 2.0, 3.0);
        Vector3D v2 = new Vector3D(4.0, 5.0, 6.0);
        Console.WriteLine("Вектор 1:");
        v1.Display();
        Console.WriteLine("Вектор 2:");
        v2.Display();

        Vector3D sum = v1.Add(v2);
        Console.WriteLine("Сложение: ");
        sum.Display();

        Vector3D diff = v1.Subtract(v2);
        Console.WriteLine("Вычитание: ");
        diff.Display();

        double dot = v1.MultiplyScalar(v2);
        Console.WriteLine($"Скалярное произведение: {dot}");

        Vector3D scaled = v1.MultiplyByScalar(2.5);
        Console.WriteLine("Умножение на 2.5: ");
        scaled.Display();

        bool compr = v1.Сomparison(v2);
        Console.WriteLine($"Вектора равны по координатам? {compr}");

        double len1 = v1.Length();
        double len2 = v2.Length();
        Console.WriteLine($"Длина вектора 1: {len1:F4}");
        Console.WriteLine($"Длина вектора 2: {len2:F4}");

        int comparison = v1.CompareLength(v2);
        if (comparison == -1)
            Console.WriteLine("Вектор 1 короче вектора 2");
        else if (comparison == 0)
            Console.WriteLine("Векторы равны по длине");
        else
            Console.WriteLine("Вектор 1 длиннее вектора 2");
    }
}