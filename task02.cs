// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int n = 6;

int[] Array(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,100);
    }
    return arr;
}

int[] SumUnevenPos(int[] arr)
{
    int[] sum = new int[1];
    for (int j = 0; j < arr.Length; j++)
    {
        if (j % 2 != 0)
        sum[0] += arr[j];
     
    }
    return sum;
}


void PrintArray(int[] arr)
{
    Console.WriteLine();
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write($"{arr[k]} ");
    }
    Console.WriteLine();
}
Console.Write($"Massive: ");
int[] array = Array(n);
PrintArray(array);
Console.Write($"Sum of elements in uneven positions: ");
PrintArray(SumUnevenPos(array));