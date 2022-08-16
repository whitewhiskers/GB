// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
System.Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());
int Lenght (int num)
{
    int result = 0;
    if (num < 10) return 1;
    while (num != 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}

int result = Lenght(number);
System.Console.WriteLine($"Длина вашего числа = {result}");


