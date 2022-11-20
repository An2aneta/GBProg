// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int N;
int i;
string line;

N = 21;
i = 2;
line = "";

while(i <= N)
{
    line = line + i.ToString() + " ";
    i = i + 2;
}

Console.WriteLine(line);