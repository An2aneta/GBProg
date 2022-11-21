// Программа которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

// Вводим число
// ДЕлим число на 7 и 23
// если делится - то кратно
// если нет - не кратно

Console.WriteLine("Enter value: ");
int value = Convert.ToInt32(Console.ReadLine());


int a = value % 7;
int b = value % 23;

if(a == 0 & b == 0)
{

    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно");
}
