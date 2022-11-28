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

  int[] NewArraySum(int[] array1, int[] array2, int degreemax, int degreemin)
  {
     
    int[] resultArray = new int[degreemax]; 
     
     for(int i = 0; i< degreemin; i++)
    {
       resultArray[i] = array1[i] + array2[i];
    }

        if(array1.Length > array2.Length)
        {
            for(int i = degreemin; i< degreemax; i++)
                 {
                     resultArray[i] = array1[i];
                 }
        }
        else
        {
            for(int i = degreemin; i< degreemax; i++)
                 {
                     resultArray[i] = array2[i];
                 }
        }
     
    return resultArray;
  }

int[] NewArraySub(int[] array1, int[] array2, int degreemax, int degreemin)
  {
     
    int[] resultArray = new int[degreemax]; 
     
     for(int i = 0; i< degreemin; i++)
    {
       resultArray[i] = array1[i] - array2[i];
    }

        if(array1.Length > array2.Length)
        {
            for(int i = degreemin; i< degreemax; i++)
                 {
                     resultArray[i] = array1[i];
                 }
        }
        else
        {
            for(int i = degreemin; i< degreemax; i++)
                 {
                     resultArray[i] = array2[i];
                 }
        }
     
    return resultArray;
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


  string Printres(int[] resArr)
  {
    string output = String.Empty;
    for(int i = 0; i < resArr.Length; i++)
    {
        int t = resArr[i];
        if (t == 0) continue;
        if (t != 0 && i == 0) {output += $"{t}"; }
        if (t == 1 && i == 1) {output += $" + x"; }
        if (t != 1 && i == 1 && i != 0 && t>0) {output += $" + {t}x"; }
        if (t == 1 && i != 1 && i != 0) {output += $" + x^{i}"; }
        if (t != 1 && i != 1 && t !=0 && t > 0 && i !=0) {output += $" + {t}x^{i}"; }
        if (t != 1 && i != 1 && t !=0 && t < 0 && i !=0) {output += $"{t}x^{i}"; }

    }
        return output;
  }

  Console.WriteLine("Введите степень первого многочлена: ");
  int n1 = Convert.ToInt32(Console.ReadLine()) + 1;
  int[] firstArray = CreateArray(n1);
  Console.WriteLine("Введите степень второго многочлена: ");
  int n2 = Convert.ToInt32(Console.ReadLine()) + 1;
  int[] secondArray = CreateArray(n2);
  Fill(firstArray, -10, 10);
  Fill(secondArray, -10, 10);

  int maxDegree = n1;
  int minDegree = n2; 
  if (n2 > n1)
  {
    maxDegree = n2;
    minDegree = n1;
  } 
  
  int[] sumArray =  NewArraySum(firstArray, secondArray, maxDegree, minDegree);
  int[] subArray =  NewArraySub(firstArray, secondArray, maxDegree, minDegree);

  Console.WriteLine(PrintGood(firstArray));
  Console.WriteLine(PrintGood(secondArray));
  Console.WriteLine(PrintGood(sumArray));
  Console.WriteLine();
 // Console.WriteLine(PrintGood(subArray));
  
  Console.WriteLine(Printres(firstArray));
 
  Console.WriteLine(Printres(secondArray));
  Console.WriteLine("Сумма многочленов равна ");
  Console.WriteLine(Printres(sumArray));

 
  
  Console.WriteLine("Разность многочленов равна ");
  Console.WriteLine(Printres(subArray));
  


  

