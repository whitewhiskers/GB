// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 1000 && number > 99)
{
    result = number / 10 % 10;
    System.Console.WriteLine($"Ваша средняя цифра числа {number} -> {result}");
}
else System.Console.WriteLine($"Вы ввели не трехзначное число");
