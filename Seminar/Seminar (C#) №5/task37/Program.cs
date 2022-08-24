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
int[] MyltiplyPairNum(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size++;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = arr[i] * arr[arr.Length -i -1];
    }
    if (arr.Length % 2 != 0) array[array.Length - 1] = arr[arr.Length / 2];
    return array;

}
System.Console.Write("Введите длину массива = ");
int number = int.Parse(Console.ReadLine());
int[] array = FillArray(number);
PrintArray(array);
int[] array2 = MyltiplyPairNum(array);
System.Console.Write(" -> ");
PrintArray(array2);

