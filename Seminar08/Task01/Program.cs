// Показать двумерный массив, заполненный целыми числами

// Метод создания массива

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


//Метод печати массива
void PrintTwoDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],4}");
    }
    Console.WriteLine();
  }
}

int [,] matrix = CreateTwoDimArray(5, 7);
FillTwoDimArray(matrix, -10, 10);
PrintTwoDimArray(matrix);