using System.Collections.Specialized;

int f(int N)
{
    if (N == 0)
    {
        return 0;
    }
    if (N == 1)
    {
        Console.Write($"{N}");
    }
    else
    {
        Console.Write($"{N}, ");
    }
    return f(N - 1);
}


int N = Convert.ToInt32(Console.ReadLine());
f(N);
