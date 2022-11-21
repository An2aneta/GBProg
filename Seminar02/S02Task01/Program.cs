// программа принимает на вход 2 числа и выводить является ли второе число кратным первому, 
// если -нет вывести остаток от деления

// в программу вводится 1 число
// в программу вводится 2 число
// найти остаток от деления ч1 на ч2
// проверить если остаток не равен 0 то показать его
// иначе показать сообщение о кратнос

Console.WriteLine("start");

int firstNumber = 25;
int secondNumber = 6;

int remainder = firstNumber % secondNumber;

if (remainder !=0)
{

    Console.WriteLine(remainder);
}

else
{

    Console.WriteLine("Кратно");
}