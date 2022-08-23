// НОД Алгоритм Евклида
// НОД (14, 21) = 7

int n = 45;
int m = 78;

int prod = m * n;

while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
    //    Console.WriteLine($"{n}\t {m}");
}

Console.WriteLine($"НОД = {n}");
Console.WriteLine($"НОК = {prod/n}");

