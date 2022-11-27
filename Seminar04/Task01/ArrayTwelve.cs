using static MyLibrary;
// Задачи на сегодня
Console.Clear();

// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] col = CreateArray(12);
// Console.WriteLine(PrintGood(col));
// Fill(col, -9, 9);
// Console.WriteLine(PrintGood(col));
// int pos = SumPositive(col);
// Console.WriteLine($">0 {pos}");
// int neg = SumNegative(col);
// Console.WriteLine($"<0 {neg}");


// =====
/* 
int[] col3 = CreateArray(12);
Fill(col3, -9, 10);
Console.WriteLine(PrintGood(col3));
int sumPos = SumPositive(col3);
int sumNeg = SumNegative(col3);

Console.WriteLine($"Сумма положительных элементов: {sumPos}");

Console.WriteLine();

Console.WriteLine($"Сумма отрицательных элементов: {sumNeg}");
*/

//==========
// Задача 2: Напишите программу замена элементов
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// =====
// int[] col2 = CreateArray(10);
// Console.WriteLine(PrintGood(col2));
// Fill(col2, -20, 20);
// Console.WriteLine(PrintGood(col2));

// int[] res = Inverse1(col2);
// Inverse2(col2);
// Console.WriteLine(PrintGood(res));
// Console.WriteLine(PrintGood(col2));
// =====


// Задача 3: Задайте массив.
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

//int upperBound = 50;
//int searchElement = Random.Shared.Next(0, upperBound);



//bool flag1 = FindElement1(col3, searchElement);
//Console.WriteLine($"{searchElement} найден - {flag1}");

//bool flag2 = FindElement2(col3, searchElement);
//Console.WriteLine($"{searchElement} найден - {flag2}");


// =====
// Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]. 

/*
int[] array4 = CreateArray(123);
Fill(array4, 0, 200);
Console.WriteLine(PrintGood(array4));
Console.WriteLine(CountElement(array4));
*/

// Задача 5: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
// * Для нечетного количество центральный элемент возводится в квадрат

int[] array4 = CreateArray(10);
Fill(array4, 0, 10);
Console.WriteLine(PrintGood(array4));
int sizeArray = array4.Length/2;
if (sizeArray % 2 ==0)
{
    int[] array5 = MultElementEven(array4);
}
else
{
    int[] array5 = MultElementOdd(array4);
}


Console.WriteLine(PrintGood(array5));