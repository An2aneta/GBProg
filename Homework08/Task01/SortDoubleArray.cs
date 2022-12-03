// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

// Метод сортировки по убыванию элементов строки

int[,]  SortMaxMinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
               if(array[i,j] < array[i,k])
                {
                    int temp = array[i,k]; 
                    array[i,k] =  array[i,j];
                    array[i,j] = temp;
                }
            }
           
        }
    }
    
    return array;
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



int [,] matrix = CreateTwoDimArray(10, 10);
FillTwoDimArray(matrix, 1, 20);
Console.WriteLine(PrintTwoDimArrayGood(matrix));
int [,] matrixSort = SortMaxMinArray(matrix);
Console.WriteLine(PrintTwoDimArrayGood(matrixSort));