// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод создания трехмерного массива
int[,,]  CreateThreeDimArray(int l, int m, int n)
{
    return new int[l, m, n];
}

//Метод заполнения массива неповторяющимися двузначными числами
void FillThreeDimArray(int[,,] array, int min, int max)
{
    Random element = new Random();
    int[] temparr = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)]; 
    int l=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
               int rnd = element.Next(min, max);
               for (l = 0; l < array.GetLength(0)*array.GetLength(1)*array.GetLength(2); l++)
               {
                    while(temparr[l] == rnd) 
                    {
                        rnd = element.Next(min, max);
                    }
                    temparr[l]=rnd; 
                    array[i,j,k] = rnd;
               }

               
            }
    
        }
    }
}


string PrintThreeDimArrayGood(int[,,] array)
{
  string result = string.Empty;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
     {
      for (int k = 0; k < array.GetLength(2); k++)
        {
            result += $"{array[i, j, k]}({i},{j},{k})   ";
        }
      result += "\n";
    }
    
  }
  return result;
}

int [,,] matrix = CreateThreeDimArray(4, 5, 4);
FillThreeDimArray(matrix, 10, 100);
Console.WriteLine(PrintThreeDimArrayGood(matrix));