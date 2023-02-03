// Задача 36: Задайте одномерынй массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на 
// нечентных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] CreatingArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int SumOddElements(int[] array)
{
    int sumOdd = 0;
    for(int j = 1; j < array.Length; j+=2)
    {
        sumOdd += array[j];
    }
    return sumOdd;
}

int[] array = CreatingArray(4, -10, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициязх {SumOddElements(array)}");
