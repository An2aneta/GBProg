// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


double NumberDegree(int a, int b)
{
  double result = 1;
  for(int i = 0; i < b; i++)
  {
        result = result * a;
  }
return result;
}

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
double res = NumberDegree(number1, number2);

Console.WriteLine(res);
