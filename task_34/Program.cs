// Задача 32: Задайте массив заполненный случайными
// положительными числами. Напишите программу, которая
// покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int [] CreatingArray(int size, int minNumber, int maxNumber)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    { 
    res[i] = new Random().Next(minNumber, maxNumber);
    }
    return res;
}

int EvenOdd(int[] array)
{
    int even = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

int[] array = CreatingArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Колличество четных чисел в массиве: {EvenOdd(array)}");
