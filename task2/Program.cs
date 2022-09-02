// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

int SumElsOnOddPosition(int[] arr)
{
    int sum = 0;
    
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }

    return sum;
}

int[] array = new int[6];
FillArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов на нечётных позициях = {SumElsOnOddPosition(array)}");