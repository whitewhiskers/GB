// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.Write("Введите количество чисел которые будете вводить:  ");
int countPos = 0;
int count = int.Parse(Console.ReadLine());
for (int i = 1; i <= count; i++)
{
    System.Console.Write($"Введите {i} число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0) countPos++;
}
System.Console.Write($"Положительных чисел -> {countPos}");