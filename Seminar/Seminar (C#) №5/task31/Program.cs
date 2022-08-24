int size = 12;

int[] FillArray(int length)
{
    int [] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}

int [] array = FillArray(size);
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0) sumMinus += array[i];
    else if (array[i] > 0) sumPlus += array[i];
}
System.Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
{
    System.Console.Write($"{array[i]},");
}
System.Console.Write($"{array[array.Length-1]}]");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных чисел = {sumPlus}");
System.Console.WriteLine($"Сумма отрицательных чисел = {sumMinus}");