// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
int result1 = Factorial(number);
Console.WriteLine($"Факториал вашего числа {number} = {result1}");
