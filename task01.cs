// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int n = 4;

int[] Array(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

int[] CountEvenDigit(int[] arr)
{
    int[] evenDigit = new int[1];
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] % 2 == 0)
        evenDigit[0]++;
     
    }
    return evenDigit;
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
int[] array = Array(n);
Console.Write($"Massive: ");
PrintArray(array);
Console.Write($"Number of even numbers in the array: ");
PrintArray(CountEvenDigit(array));
