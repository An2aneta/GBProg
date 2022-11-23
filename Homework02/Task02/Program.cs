// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


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


int GiveThirdNumber(int value, int length)
{ 
    int tempNumber = 0;
    int tempValue = value;
    int result = 0;
    if(length <=2) 
    {
        return result;
    }
    else
    {
        for(int i = 1; i < 4; i++)
        {
            tempNumber = (tempValue / Convert.ToInt32((Math.Pow(10, length-i))));
            tempValue = tempValue - (tempNumber * Convert.ToInt32(Math.Pow(10, length-i)));
   
        }
       
    }
    return tempNumber;
}

int inputNumber = GetNumber("Введите число: ");
int inputLength = GetLehgthNumber(inputNumber);
int thirdNumber = GiveThirdNumber(inputNumber, inputLength);
if(inputLength<=2) Console.Write("Третьей цифры нет");
else 
{Console.Write("Третья цифра числа ");
Console.Write(inputNumber);
Console.Write(" - ");
Console.Write(thirdNumber);
Console.Write(".");}
