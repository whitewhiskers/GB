// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMean(int[,] arr)
{
    double sum = 0;
    double result = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        result = Math.Round(sum / arr.GetLength(0), 1);
        if (i < arr.GetLength(1)-1) System.Console.Write($"{result}; ");
        else System.Console.Write($"{result}.");
        sum = 0;
        result = 0;
    }
}
int[,] FillArray(int str, int stb)
{
    int[,] array = new int[str, stb];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.Write("Количество строк массива = ");
int numberStr = int.Parse(Console.ReadLine());
System.Console.Write("Количество столбцов массива = ");
int numberStb = int.Parse(Console.ReadLine());
int[,] array = FillArray(numberStr, numberStb);
PrintArray(array);
ArithmeticMean(array);