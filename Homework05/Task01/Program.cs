//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// метод, который создаёт массив
 int[] CreateArray(int count)
  {
    return new int[count];
  }

  // заполняет массив
void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      //array[i] = new Random().Next(min, max);
    }
  }

int EvenCount(int[] array, int size)
{
    int CountEvenNumber = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] % 2 == 0)
        {
            CountEvenNumber ++;
        }
    }
return CountEvenNumber;

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


 int[] arr = CreateArray(10);
 Fill(arr, 100, 999);
 Console.WriteLine(PrintGood(arr));
 int count = EvenCount(arr, 10);
 Console.WriteLine(count);

