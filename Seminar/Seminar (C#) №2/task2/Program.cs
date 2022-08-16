System.Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"Ваше число {number} делится на 7 и на 23");
}
else System.Console.WriteLine($"Ваше число {number} не делится на 7 и на 23");


