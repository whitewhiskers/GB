// Напишите программу, которая 
// выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.
// 78 -> 8
// 56 -> 6 
// 95 -> 9

int number = new Random().Next(10, 100);
System.Console.WriteLine($"Ваше случайное число из отрезка [10,99] -> {number}");
// int a = number / 10;
// int b = number % 10;
// if (a > b) System.Console.WriteLine($"Наибольшая цифра числа {number} -> {a}");
// else if (a < b) System.Console.WriteLine($"Наибольшая цифра числа {number} -> {b}");
// else System.Console.WriteLine("Цифры равны");

int MaxChar(int num)
{
    int a = num / 10;
    int b = num % 10;
    if (a > b) return a;
    return b;
}

int result = MaxChar(number);
System.Console.WriteLine($"Наибольшая цифра числа {number} -> {result}");
