int size;
int n = 1;

Console.WriteLine("Введите число N");
size = int.Parse(Console.ReadLine());

while (n < size)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    n++;
}