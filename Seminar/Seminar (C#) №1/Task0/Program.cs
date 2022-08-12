// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
long number = Convert.ToInt64(Console.ReadLine());
long square = number * number;
Console.Write($"Квадрат вашего числа: {square}");