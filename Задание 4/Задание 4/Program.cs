int size;

Console.WriteLine("Введите размер");
size = int.Parse(Console.ReadLine());

for (int n = 0; n < size + 2; n++)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = size; j < i; j--)
        {
            Console.Write(" ");
        }

        for (int k = 0; k * 2 < i - 1; k++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}