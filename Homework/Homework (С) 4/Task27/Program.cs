// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits (int num)
{
    int res = 0;
    num = Math.Abs(num); 
    while(num > 0)
    {
        res = res + (num % 10);
        num = num /10;
    }
    return res;
}

int sum = SumDigits(number);
System.Console.WriteLine($"Сумма чисел в вашем числе {number} -> {sum}");