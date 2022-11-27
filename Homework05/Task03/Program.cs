// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateArray(int count)
  {
    return new double[count];
  }

  // заполняет массив
void Fill(double[] array, int min, int max)
  {
    int size = array.Length;
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = rand.NextDouble() * (max+1 - min) - max+1;
      //array[i] = new Random().Next(min, max);
    }
  }

  string PrintGood(double[] numbers)
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

double FindMaxEl(double[] arrayForMax, int length)
{
    int i = 0;
    double max = arrayForMax[i];
    while (i < length)
    {
        if (arrayForMax[i] > max)
        {
            max = arrayForMax[i];
        }
        i++;
    }
    return max;
}

double FindMinEl(double[] arrayForMin, int length)
{
    int i = 0;
    double min = arrayForMin[i];
    while (i < length)
    {
        if (arrayForMin[i] < min)
        {
            min = arrayForMin[i];
        }
        i++;
    }
    return min;
}


double[] arrayDouble = CreateArray(10);
 Fill(arrayDouble, -20, 20);
 Console.WriteLine(PrintGood(arrayDouble));
 double maxEl = FindMaxEl(arrayDouble, 10);
 Console.WriteLine(maxEl);
 double minEl = FindMinEl(arrayDouble, 10);
 Console.WriteLine(minEl);

 double result = maxEl - minEl;
 Console.WriteLine(result);