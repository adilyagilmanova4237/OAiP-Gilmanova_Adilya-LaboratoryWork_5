using System;
public class Calculator
{
    public double first;
    public int second;
    public void Read()
    {
        Console.Write("Введите оклад: ");
        first = double.Parse(Console.ReadLine());
        Console.Write("Введите количество отработанных дней: ");
        second = int.Parse(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine($"Оклад: {first}, Отработано дней: {second}");
    }
    public double Summa()
    {
        const int workday = 27;
        return first / workday * second;
    }
}
class Program
{
    static void Main()
    {
        Calculator zarp = new Calculator();
        zarp.Read();
        zarp.Display();
        Console.WriteLine($"Начисленная зарплата: {zarp.Summa()}");
    }
}