// Программа которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

// Вводим число
// ДЕлим число на 7 и 23
// если делится - то кратно
// если нет - не кратно

Console.WriteLine("Enter value1: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value2: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1*value1 == value2) 
{

    Console.WriteLine("value2 является квадратом value1");
}
else 

//Console.WriteLine("Ни одно из чисел не является квадратом другого");


if(value2*value2 == value1) 
{

    Console.WriteLine("value1 является квадратом value2");
}
else Console.WriteLine("Ни одно из чисел не является квадратом другого");



// int a = value % 7;
// int b = value % 23;

/*if(a == 0 & b == 0)
{

    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно");
}
*/