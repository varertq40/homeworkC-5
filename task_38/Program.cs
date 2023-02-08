// Задача 38: Задайте массив вещественных 
// чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] array = new double[5];
Random rnd = new Random();

void FillArray(double[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    { 
    array[i] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
    }
    return;
}

void FindingDifference(double[] array)
{   
    double min = array[0];
    double max = array[0];
    double difference = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            if (array[i] > max)
            max = array[i];
        }
    }
    difference = min - max;
    Console.WriteLine($"Разница между {max} и {min} равна {difference}");
}

FillArray(array);
Console.WriteLine(string.Join(" ",array));
FindingDifference(array);
