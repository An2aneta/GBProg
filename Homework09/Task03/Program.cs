// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(m, n) = n+1 если m = 0
//           = A(m-1, 1), если n = 0, m != 0
//           = A(m-1, A(m,n-1)), если m > 0, n > 0   


int Ackerman(int m, int n)
{
    if(m == 0) 
    {
         return n+1;
    }
    else 
    {
        if (n == 0 && m != 0)
        {
            return Ackerman(m-1, 1);
        } 
    
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }
}

Console.WriteLine(Ackerman(1, 1));