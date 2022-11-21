/*
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю 
последовательность (сдвиг - циклический) на |K| элементов вправо, 
если K – положительное и влево, если отрицательное.
*/


// Запрос количества элементов массива
Console.WriteLine("Enter element number: ");
int n = Convert.ToInt32(Console.ReadLine());

// Запрос числа K
Console.WriteLine("Enter K: ");
int k = Convert.ToInt32(Console.ReadLine());


int[] array = new int[n];

// Заполнение массива

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 100);
}

Console.WriteLine($"Начальный массив: {String.Join(", ", array)}\n");

int[] array_new = new int[n];

if (k > 0)
{
    for (int i = 0; i < n; i++)
    {
        {
            array_new[(i + k) % n] = array[i];
        }

    }
}
else if (k < 0)
{
    for (int i = 0; i < n; i++)
    {
        {
            array_new[(n + i + k) % n] = array[i];
        }

    }
}

else
{
    array_new = array;

}

Console.WriteLine($"Конечный массив: {String.Join(", ", array_new)}\n");