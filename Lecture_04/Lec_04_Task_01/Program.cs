/*
[6,44,435,6,1,31,43,-24,54,-2,-33,4,-652]


*/
// Запрос количества элементов массива
Console.WriteLine("Enter element number: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];

// Заполнение массива

for (int i = 0; i < n; i++)
{
    array[i]  = new Random().Next(-100,100);
}

Console.WriteLine($"Начальный массив: {String.Join(", ", array)}\n");

for (int i = 0; i < n-1; i++)
{
    int MinIndex = i;
    for (int j = i+1;j <n;j++)
    {
        if (array[j] < array[MinIndex])
        MinIndex = j;        
    }
    int temp;
    temp = array[MinIndex];

    array[MinIndex] = array[i];
    array[i] = temp;
}

Console.WriteLine($"Конечный массив: {String.Join(", ", array)}\n");