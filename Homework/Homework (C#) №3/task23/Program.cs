// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.Write("Введите ваше число:");
int number = int.Parse(Console.ReadLine());
void CalcTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            System.Console.WriteLine($"{i}\t{i * i * i}");
        }
    }
    else if (num < 0)
    {
        for (int i = 0; i >= num; i--)
        {
            System.Console.WriteLine($"{i}\t{i * i * i}");
        }
    }
    else System.Console.WriteLine("Введено неверное число");
}
System.Console.WriteLine("Ваша таблица чисел в кубе:");
CalcTable(number);