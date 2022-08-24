// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}
void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write("{0:F1}; ", arr[i]);
        else System.Console.Write("{0:F1}", arr[i]);
    }
    System.Console.Write("]");
}

double DiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    double result = max - min;
    return result;
}
Console.Clear();
System.Console.Write("Введите длину массива = ");
int number = int.Parse(Console.ReadLine());
double[] array = CreateArrayRndDouble(number, 10, 100);
double diff = DiffMaxMin(array);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.WriteLine("{0:F1}", diff);