// есть массив целых чисел
//написать программу, которая создаст и распечатает массив состоящий только из четных чисел

//массив исходный
//считываем поэлементно, проверяем на четность
//если да - увеличиваем счетчик
//создаем новый массив размером со счетчик//
//еще раз проверяем на четность
//записываем в другой массив

// Описать
// Метод, считывающий число от пользователя из консоли
// Метод, создающий массив с указанным количеством элементов
// Метод, заполняющий массив поэлементно от пользователя
// метод подсчета четных элементов
// метод формирующий новый массив на основе имеющегося

//int array[];
//length = array.length;


int GetNumber(string text)
{
    ConsoleWriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] CreateArray(int count)
{
return new int[count];
}
    

void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    array[index] = GetHashCode Number($"array[{index}]: "")
}


int CountElements(int[] elements)
{
    int result = 0;
    int size = elements.Length;
    int i = 0;
    while(i < size)
    {
        if elements[i]% 2 = 0
    }
    return result;
}

int[] Solution(int[] collectionsElements, int evenCounts)
{
    int[] items = new int[evenCounts];
    int length = collectionsElements.Length;
    int position = 0;
    int indexInItems = 0;
    while(position < length)
    {
        if(collectionsElements[position]%2 = 0)
        {
            items[indexInItems] = collectionsElements[position]
        } 
    }
}

void PrintArrayBad(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
}
    

]


}


//Console.WriteLine("Enter value1: ");
//int value1 = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("Hello, World!");
