// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
System.Console.Write("Количество строк массива = ");
int numberStr = int.Parse(Console.ReadLine());
System.Console.Write("Количество столбцов массива = ");
int numberStb = int.Parse(Console.ReadLine());

double[,] FillArray(int str, int stb)
{
    double[,] array = new double[str, stb];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.NextDouble() * (10 - 1) + 1;
        }
    }
    return array;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("{0:F1} ",arr[i,j]);
        }
    System.Console.WriteLine();
    }
}

double [,] array = FillArray(numberStr,numberStb);
PrintArray(array);