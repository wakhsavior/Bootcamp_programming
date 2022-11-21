Console.WriteLine("Enter element number: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] array = new string [n];

// Заполнение массива

for (int i = 0; i < n; i++)
{
    array[i]  = Console.ReadLine();
}

Console.WriteLine($"Начальный массив: {String.Join(", ", array)}\n");

for (int i = 0; i < n-1; i++)
{
    int MinIndex = i;
    for (int j = i+1;j <n;j++)
    {
        if (array[j].Length < array[MinIndex].Length)
        MinIndex = j;        
    }
    string temp;
    temp = array[MinIndex];

    array[MinIndex] = array[i];
    array[i] = temp;
}

Console.WriteLine($"Конечный массив: {String.Join(", ", array)}\n");