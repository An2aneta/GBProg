//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

double a = 0;
double b = 0;
string a1;
string b1;
Console.WriteLine("Введите первое число");
a1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
b1 = Console.ReadLine();

// Нужно проверить на пустую строку, либо ввести маску только на цифры
a = double.Parse(a1);
b= double.Parse(b1);

if (a > b)
{
    Console.WriteLine("первое число больше второго");
}
else
{
     Console.WriteLine("второе число больше первого");
}
