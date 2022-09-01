// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
System.Console.Write("Количество строк массива = ");
int numberStr = int.Parse(Console.ReadLine());
System.Console.Write("Количество столбцов массива = ");
int numberStb = int.Parse(Console.ReadLine());
System.Console.Write("Введите строку элемента массива = ");
int numStr = int.Parse(Console.ReadLine());
System.Console.Write("Введите столбец элемента массива = ");
int numStb = int.Parse(Console.ReadLine());

int [,] FillArray(int str, int stb)
{
    int[,] array = new int[str, stb];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 10);
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
            System.Console.Write($"{arr[i,j]} ");
        }
    System.Console.WriteLine();
    }
}
int [,] array = FillArray(numberStr,numberStb);
PrintArray(array);
if (numStr > array.GetLength(0) || numStb > array.GetLength(1)) 
{
    System.Console.WriteLine("Такого элемента в массиве нет");
    return;
}
System.Console.Write($"Значение вашего элемента c индексом {numStr},{numStb} -> {array[numStr-1,numStb-1]}");
