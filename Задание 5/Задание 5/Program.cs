﻿int m = 1000;
int sum = 0;

for (int i = 0; i <= m; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);