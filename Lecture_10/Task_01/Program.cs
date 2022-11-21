/* Сортировка подсчетом. Суть алгоритма в том, что мы считаем количество каждого из числа от 0 до 9 (цифра). Можно изменить алгоритм путем увеличения диапазона
 от min до max например от -100 до 100
 */

int[] array = { 0, 2, 5, 2, 4, 6, 6, 5, 3, 7, 5, 2, 8, 0, 6, 2, 3, 6, 9, 0 };
int[] array2 = { 2, 4, 1, 43, 52, 45, -31, -54, 6, 2, 45, 65, 76, 23, 5, 75, 3, 1, 35, -3, 6, 8, 9, 0, 8, 32, 21, 32, 44, 23, -10, 54, 7, 4, 23, 5, 6, -1, 43, 76, 4 };
PrintArray(array);
CountingSort(array);
PrintArray(array);
Console.WriteLine(string.Join(", ", array));

PrintArray(array2);
Console.WriteLine(string.Join(", ", CountingSortExtended(array2)));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];   // Массив повторений
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;

    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            //Console.Write($"{i}, ");
            inputArray[index] = i;
            index++;
        }
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1];

    Console.WriteLine(max + offset + 1);
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            //Console.Write($"{i}, ");
            sortedArray[index] = i - offset;
            index++;
        }
    }
    return sortedArray;
}