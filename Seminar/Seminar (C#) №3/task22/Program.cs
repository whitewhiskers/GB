Console.Clear();
System.Console.Write("Введите ваше число:");
int number = int.Parse(Console.ReadLine());
void CalcTable(int num)
{
    if (num>0)
    {
        for (int i = 1; i<=num; i++)
        {
            System.Console.WriteLine($"{i}\t{i*i}");
        }
    }
    else if (num<0)
    {
        for (int i = 0; i>=num; i--)
        {
            System.Console.WriteLine($"{i}\t{i*i}");
        }
    }
    else System.Console.WriteLine("Введено неверное число");
}
System.Console.WriteLine("Ваша таблица:");
CalcTable(number);