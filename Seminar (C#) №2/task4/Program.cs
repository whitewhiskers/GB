System.Console.WriteLine("Введите ваше первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите ваше второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 * number1 == number2)
{
    System.Console.WriteLine($"Ваше число {number2} является квадратом {number1}");
}
else if (number2 * number2 == number1)
{
    System.Console.WriteLine($"Ваше число {number1} является квадратом {number2}");
}
else System.Console.WriteLine("Ваше числа не являются квардратами друг другу");