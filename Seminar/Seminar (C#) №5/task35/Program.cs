int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 123);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]},");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.WriteLine("]");
}

int CheckValue(int [] arr, int min, int max)
{
    int numberValue = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min-1 && arr[i] < max-1) numberValue++;
    }
    return numberValue;
}
int[] array = FillArray(123);
PrintArray(array);
int value = CheckValue(array,10,99);
System.Console.WriteLine($"Количество чисел на отрезке [10,99] -> {value}");
