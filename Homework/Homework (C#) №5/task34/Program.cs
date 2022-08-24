// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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
int CheckEvenNumbers(int [] arr)
{
    int count = 0;  
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++; 
    }
    return count;
}
Console.Clear();
System.Console.Write("Введите длину массива = ");
int number = int.Parse(Console.ReadLine());
int [] array = FillArray(number);
int countEvenNumbers = CheckEvenNumbers(array);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.WriteLine(countEvenNumbers);
