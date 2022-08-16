// Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Тут неправильный пример



int number = 8;

int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next();
    }
    return array;
}
int[] result = GetArray(number);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

PrintArray(result);

//Вариант с указанием размера и диапазона значений

// Console.Write("Введите число элементов массива: ");
// int number = int.Parse(Console.ReadLine());
// if (number <= 0)
// {
//     Console.Write("Вы ввели недопустимое значение");
//     return;
// }
// Console.Write("Введите первое число диапазона значений чисел массива: ");
// int smallDigit = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число диапазона значений чисел массива: ");
// int bigDigit = int.Parse(Console.ReadLine());
// if (smallDigit > bigDigit)
// {
//     Console.Write("Вы ввели недопустимое значение");
//     return;
// }

// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {

//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// int[] result = GetArray(number, smallDigit, bigDigit);

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }
//     Console.Write($"{array[array.Length - 1]}]");
// }

// PrintArray(result);