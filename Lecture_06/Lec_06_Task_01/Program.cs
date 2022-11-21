/*

Быстрая сортировка, наихудший O(N*N), средний O(NlogN), лучший O(N)
Берется опорный элемент, нужно чтобы все элементы меньше опорного стояли слева от опорного, а больше справа
Вызвать для подмасива слева ту-же функцию, и справа. Тоесть вызывать рекурсию.

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
Console.WriteLine($"Начальный массив : {String.Join(", ", array)}\n");

int[] res = QuickSort(array, 0, array.Length - 1);

Console.WriteLine($"Итоговый массив  : {String.Join(", ", res)}\n");

int[] QuickSort(int[] InputArray, int MinIndex, int MaxIndex)
{
    if (MinIndex>=MaxIndex) return InputArray;
    int pivot = GetPivotIndex(InputArray, MinIndex, MaxIndex);
    QuickSort(InputArray, MinIndex, pivot - 1);
    QuickSort(InputArray, pivot + 1, MaxIndex);
    return InputArray;

}

int GetPivotIndex(int[] InputArray, int MinIndex, int MaxIndex)
{
    int PivotIndex = MinIndex - 1;
    for (int i = MinIndex; i < MaxIndex; i++)
    {
        if (InputArray[i] < InputArray[MaxIndex])
        {
            PivotIndex++;
            Swap(InputArray, i, PivotIndex);
        }
    }
    PivotIndex++;
    Swap(InputArray, PivotIndex, MaxIndex);
    return PivotIndex;
}

void Swap(int[] InputArray, int LeftValue, int RightValue)
{
    int temp = InputArray[LeftValue];
    InputArray[LeftValue] = InputArray[RightValue];
    InputArray[RightValue] = temp;
}