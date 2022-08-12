System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    System.Console.WriteLine($"{number1} является квардратом {number2}");
}
else
{
    System.Console.WriteLine($"{number1} не является квардратом {number2}");
}
123