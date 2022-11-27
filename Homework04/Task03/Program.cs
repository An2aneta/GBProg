// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int count)
  {
    return new int[count];
  }

void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      
    }
  }

string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += ($"{numbers[i],3}, ");
      i++;
    }
    return result + "]";
  }


int[] array8 = CreateArray(8);
Fill(array8, -4, 4);
Console.WriteLine(PrintGood(array8));