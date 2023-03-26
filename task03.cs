// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов 
// массива.

// [3 7 22 2 78] -> 76


int n = 6;

double[] Array(int n)
{
    double[] arr = new double[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().NextDouble();

    return arr;
}

double[] MaxDiffMin(double[] arr)
{
    double max = arr.Max();
    double min = arr.Min();
    double[] diff = new double[1];
    for (int i = 0; i < arr.Length; i++)
        diff[0] = max - min;
    return diff;
    
}

void PrintArray(double[] arr)
{
    Console.WriteLine();
    for (int k = 0; k < arr.Length; k++)
        Console.Write($"{arr[k]} ");
    Console.WriteLine();
}
Console.Write($"Massive: ");
double[] array = Array(n);
PrintArray(array);
Console.Write($"Difference between max and min is: ");
PrintArray(MaxDiffMin(array));