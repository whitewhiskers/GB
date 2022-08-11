int number = new Random().Next(100,1000);
System.Console.WriteLine($"Ваше случайное трехзначное число: {number}");

int DeleteMiddleChar(int num)
{
    int firstchar = num / 100;
    int lastchar = num % 10;
    return firstchar*10+lastchar;
}

int result = DeleteMiddleChar(number);
System.Console.WriteLine($"Ваше число без средней цифры: {result}");