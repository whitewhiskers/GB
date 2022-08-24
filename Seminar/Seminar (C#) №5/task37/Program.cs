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
    System.Console.WriteLine("]");
}
int[] MyltiplPairNum(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] array = new int[arr.Length / 2];
        int l = -1;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            array[i] = arr[i] * arr[arr.Length + l];
            l--;
        }
        return array;
    }
    else
    { 
        int[] array = new int[arr.Length / 2 +1];
        int l = -1;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            array[i] = arr[i] * arr[arr.Length + l];
            l--;
        }
        array[array.Length-1] = arr[arr.Length / 2];
        return array;
    }
}
int[] array = FillArray(3);
PrintArray(array);
int[] array2 = MyltiplPairNum(array);
PrintArray(array2);

