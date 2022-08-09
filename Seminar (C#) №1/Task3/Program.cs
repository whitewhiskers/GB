System.Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberMinus = -number;
while (numberMinus<number)
{
    
    Console.Write($"{numberMinus},");
    numberMinus++;
}
if(numberMinus == number)
    {
        Console.Write(numberMinus);
        numberMinus++;
    }