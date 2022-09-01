int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 10);
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
    System.Console.Write("]");
}
void ReverseArray(int [] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[size-1-i];
        arr[size-1-i] = tmp;
    }
}
Console.Clear();
System.Console.Write("Введите длину массива = ");
int number = int.Parse(Console.ReadLine());
int[] array = FillArray(number);
PrintArray(array);
System.Console.WriteLine();
ReverseArray(array);
PrintArray(array);
