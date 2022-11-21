/*

Сортировка пузырьком сложность O(N*N)

*/


// Запрос количества элементов массива
Console.WriteLine("Enter element number: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

// Заполнение массива

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 100);
}

Console.WriteLine($"Начальный массив    : {String.Join(", ", array)}\n");

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;

        }
    }
    Console.WriteLine($"Промежуточный массив: {String.Join(", ", array)}\n");
}

Console.WriteLine($"Конечный массив     : {String.Join(", ", array)}\n");
