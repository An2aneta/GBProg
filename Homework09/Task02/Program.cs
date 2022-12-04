// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumEl(int m, int n)
{
    int sum = n;
    if(m != n)
    {
        sum = sum + SumEl(m, n - 1);
    }
    return sum;
}

Console.WriteLine(SumEl(2, 8));