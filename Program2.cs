int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = M; i <= N; ++i)
{
    sum += i;
}

Console.WriteLine(sum);