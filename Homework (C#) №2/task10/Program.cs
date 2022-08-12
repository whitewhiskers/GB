// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Math.Abs(number);
if (result < 1000 && result > 99)
{
    result = result / 10 % 10;
    System.Console.WriteLine($"Ваша средняя цифра числа {number} -> {result}");
}
else System.Console.WriteLine($"Вы ввели не трехзначное число");
