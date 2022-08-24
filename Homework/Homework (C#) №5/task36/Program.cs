// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SumEvenIndex(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count += arr[i];
    }
    return count;
}
Console.Clear();
System.Console.Write("Введите длину массива = ");
int number = int.Parse(Console.ReadLine());
int[] array = FillArray(number);
int sumEven = SumEvenIndex(array);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.WriteLine(sumEven);