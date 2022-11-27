//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.


int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

int GetLehgthNumber(int value)
{
    string str = value.ToString();
    int length = str.Length;
    return length;
}


int GiveSumNumber(int value, int length)
{ 
    int tempNumber = 0;
    int SumNumber = 0;
    int tempValue = value;
    int result = 0;
   
        for(int i = 1; i <=length; i++)
        {
            tempNumber = (tempValue / Convert.ToInt32((Math.Pow(10, length-i))));
            SumNumber = SumNumber + tempNumber;
            tempValue = tempValue - (tempNumber * Convert.ToInt32(Math.Pow(10, length-i)));
   
        }
       SumNumber = SumNumber + tempValue;
    return SumNumber;
}

int inputNumber = GetNumber("Введите число: ");
int inputLength = GetLehgthNumber(inputNumber);
int sum = GiveSumNumber(inputNumber, inputLength);

{Console.Write("Сумма цифр числа ");
Console.Write(inputNumber);
Console.Write(" - ");
Console.Write(sum);
Console.Write(".");}

