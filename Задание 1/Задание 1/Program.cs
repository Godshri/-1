double a;
double b;

Console.Write("Введите длину. A= ");

a = double.Parse(Console.ReadLine());

Console.Write("Введите ширину. В= ");
b = double.Parse(Console.ReadLine());

    if (a > 0 && b > 0)
    {
        Console.WriteLine("Длина: {0}, Ширина: {1}, Площадь: {2}", a, b, a * b);
    }
    else 
    {
        Console.WriteLine("Ошибка. Данные введены неправильно");
        return;
    }