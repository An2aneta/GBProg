// //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int numberWeekDay = int.Parse(Console.ReadLine());

if(numberWeekDay == 6 | numberWeekDay == 7) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это будний день");