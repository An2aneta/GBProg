// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Метод, создающий двумерный массив
int[,]  CreateTwoDimArray(int m, int n)
{
    return new int[m, n];
}

// Метод заполнения массива
void FillTwoDimArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Random.Shared.Next(min, max + 1);
        }
    }
}

// Метод подсчета суммы элементов строки, записываем суммы строк в массив

int[] SumElRowInArray(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i,j];
        }
    }
    
    return sum;
}

// Метод нахождения строки с минимальной суммой

int MinRow(int[] array)
{
    int minIndex = 1;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {      
        if(array[i] < min)
        {
            min = array[i];
            minIndex = i+1;
        }
    }
    return minIndex;
}

// Метод печати двумерного массива
string PrintTwoDimArrayGood(int[,] array)
{
  string result = string.Empty;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += ($"{array[i, j],4} ");
    }
    result += "\n";
  }
  return result;
}


string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += ($"{numbers[i],3} ");
      i++;
    }
    return result + "]";
  }


int [,] matrix = CreateTwoDimArray(5, 6);
FillTwoDimArray(matrix, 1, 10);
Console.WriteLine(PrintTwoDimArrayGood(matrix));
int [] sumAr = SumElRowInArray(matrix);
Console.WriteLine(PrintGood(sumAr));
int minSumRow = MinRow(sumAr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов - {minSumRow}");