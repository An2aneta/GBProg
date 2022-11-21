// Программа, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа

// Сгенерировать трехзначное число
// Разбить число на цифры
// Составить новое число
// показать число

Console.WriteLine("Start");
int value = new Random().Next(100, 1000); // [100;999]

int a = value / 100;
int b = (value/100) % 10;
int c = value % 10;

int result = a*10 + c;

Console.WriteLine(value);
Console.WriteLine(result);
Console.WriteLine("End");
