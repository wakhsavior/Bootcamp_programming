
Console.Write("Enter the N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=N;i++)
{
    collatz(i);
    Console.WriteLine();
}
int collatz(int n)
{
    if (n == 1)
    {
        Console.Write("0-");
        return 0;
    }
    else if ((n % 2) == 0)
    {
         Console.Write($"{1+collatz(n / 2)}-");
        return 1 + collatz(n / 2);
    }
    else
    {
        Console.Write($"{3*n+1}-");
        return 1 + collatz(3 * n + 1);
    }
}