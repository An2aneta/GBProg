// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

int[] ArrayMaker(int value)
{
    int[] array = new int[5];
    int length = 5;
    //int tempNumber = 0;
    int tempValue = value;
    
        for(int i = 1; i < 5; i++)
        {
            int tempNumber = (tempValue / Convert.ToInt32((Math.Pow(10, length-i))));
            array[i] = tempNumber;
            tempValue = tempValue - (tempNumber * Convert.ToInt32(Math.Pow(10, length-i)));
   
        }
       
    return array;

}

int Palindrom(int[] array)
{
   
   int flag = 0;

   
    for(int i = 0; i < 1; i++)
    {
        for(int j = 4; j > 3; j--)
        {
            if (array[i] == array[j])
            {
                flag = 1;
            } 
            else 
            {
                flag = 0;
            }
        }
    }
return flag;
}

int number = GetNumber("Введите пятизначное число: ");
int[] arrayWork = ArrayMaker(number);
int isItPal = Palindrom(arrayWork);
if (isItPal==1) Console.WriteLine("Palindrom");
else  Console.WriteLine("Not Palindrom");