// 9. Показать последнюю цифру трёхзначного числа

int N;

N = 521;

while(N >= 100)
{
    N = N - 100;
}

if(N < 10)
{
    Console.WriteLine(N);
}
    
else
{
    while(N >= 10)
    {
        N = N - 10;
    }
    Console.WriteLine(N);
}

