//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


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

int SumIndexOddElements(int[] array, int size)
{
    int result = 0;
    for(int i = 1; i < size; i = i + 2)
    {
       
            result = result + array[i];
        
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


 int[] arr = CreateArray(11);
 Fill(arr, -10, 10);
 Console.WriteLine(PrintGood(arr));
 int sum = SumIndexOddElements(arr, 11);
 Console.WriteLine(sum);