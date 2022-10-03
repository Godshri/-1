byte x;
byte y;

Console.WriteLine("Введите числа");

Console.Write("Первое число: ");
x = byte.Parse(Console.ReadLine());

Console.Write("Второе число: ");
y =  byte.Parse(Console.ReadLine());

Console.Write("Операция 'И'"); Console.WriteLine(x & y);
Console.Write("Операция 'ИЛИ'"); Console.WriteLine(x | y);
Console.Write("Операция 'Исключающее ИЛИ'"); Console.WriteLine(x ^ y);