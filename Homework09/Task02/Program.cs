// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumEl(int m, int n)
{
    if(n >= m)
    {
        if(m==n) return 0;
        if(n - m == 1) return m+n;
        if(n - m >= 0)
        {
            return n + SumEl(m, n - 1);
        }
     }
    return 0;
}

Console.WriteLine(SumEl(6, 8));