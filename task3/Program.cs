// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

double GetDifference(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }

    dif = max - min;
    return dif;
}

double[] array = new double[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница = {GetDifference(array)}");
