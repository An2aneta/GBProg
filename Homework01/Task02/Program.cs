//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double a;
double b;
double c;
double max;

a = 170;
b = 20;
c = 90;
max = a;

if ( b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("Максимальное число - ");
Console.Write(max);