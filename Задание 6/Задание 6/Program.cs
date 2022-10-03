double a;
double b;
double c;

Console.WriteLine("Введите стороны треугольника");

Console.Write("Сторона a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Сторона b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Сторона c: ");
c = double.Parse(Console.ReadLine());

if (a > b+c || b > a+c || c > a+b && a > 0 && b > 0 && c > 0)
{
    Console.WriteLine("Неверный ввод");
    return;
}

double p = (a + b + c) / 2;
double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.WriteLine($"\nПолупериметр: {p}");
Console.WriteLine($"Площадь: {s}");
