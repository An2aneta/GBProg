
// метод для создания треугольника Паскаля для небольших степеней
int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

//метод для создания треугольника Паскаля для больших степеней 
double[,] CreateTriangleDouble(int row)
{
  double[,] triangleDouble = new double[row, row];
  for (int i = 0; i < row; i++)
  {
    triangleDouble[i, 0] = 1;
    triangleDouble[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangleDouble[i, j] =
      triangleDouble[i - 1, j - 1] + triangleDouble[i - 1, j];
    }
  }
  return triangleDouble;
}

//метод для вывода треугольника Паскаля для небольших степеней
void PrintTriangle(int[,] triangle)
{
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],4}");
    }
    Console.WriteLine();
  }
}

//метод для вывода треугольника Паскаля для больших степеней, печать для нечетных элементов, замененных на символ "@" 
void PrintTriangleDouble(double[,] triangleDouble)
{
  int row = triangleDouble.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangleDouble[i, j] != 0 && triangleDouble[i, j]%2 == 0) Console.Write("   ");
      if (triangleDouble[i, j] != 0 && triangleDouble[i, j]%2 != 0) Console.Write(" @ ");
    }

    Console.WriteLine();
  }
}

//метод для получения массива коэффициентов для заданной степени (небольшой)
int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

//метод для получения массива коэффициентов для заданной степени (большой)
double[] GetKoeffDouble(double[,] tr, int pow)
{
  double[] row = new double[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

//вывод многочлена
string Printres(int[] resArr)
  {
    string output = String.Empty;
    for(int i = 0; i < resArr.Length; i++)
    {
        int t = resArr[i];
         if (t == 1 && i == 0)
          {
            output += $"a^{(resArr.Length-1)} + ";
          } 
         else if(i==1)
         {
            output += $"{resArr[i]}*a^{resArr.Length - 1 -i}*b + ";
         } 
         else if (t != 1 && i !=0 && i != resArr.Length-1 && i != 1 && i != resArr.Length-2)
         {
           output += $"{resArr[i]}*a^{resArr.Length - 1 - i}*b^{i} + ";
         }
         else if(i == resArr.Length-2)
         {
           output += $"{resArr[i]}*a*b^{i} + ";
         } 
         else if (t == 1 && i == resArr.Length-1)
         {
          output += $"b^{i}"; 
         }
    }
        return output;
  }

/*
int[,] tr = CreateTriangle(10);
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, 8);

System.Console.WriteLine(String.Join(' ', koeff));

Console.WriteLine(Printres(koeff));
*/



double[,] tr = CreateTriangleDouble(125);
double[] koeff = GetKoeffDouble(tr, 123);
Console.WriteLine(String.Join(' ', koeff));

PrintTriangleDouble(tr);
