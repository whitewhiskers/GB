// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Math.Abs(number);
if (number < 100 && number > -100)
{
    System.Console.WriteLine($"В вашем числе {number} третьей цифры нет");
}
else
{
    while (result > 999) result = result / 10;
    result = result % 10;
    System.Console.WriteLine($"Третья цифра вашего числа {number} -> {result}");
}