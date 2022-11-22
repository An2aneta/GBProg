// Методы первой группы

/*
void Method1()
{
    Console.WriteLine("Autor ...")
};
*/

// Методы четвертой группы

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "aabbcc");
Console.WriteLine(res);