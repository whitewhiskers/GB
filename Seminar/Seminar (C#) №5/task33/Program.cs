int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9, 10);
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

bool FindElemArray(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

System.Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine());
int[] array = FillArray(12);
PrintArray(array);
bool find = FindElemArray(array,num);
if (find == true) System.Console.WriteLine($"Ваше число {num} есть в масиве");
else System.Console.WriteLine($"Вашего числа {num} нет в масиве");
