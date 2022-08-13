// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Усложнение: принимает на вход любое целое число

Console.Clear();
int LenghtNumber(int numb1)
{
    int countLenght = 0;
    numb1 = Math.Abs(numb1);
    if (numb1 == 0) return 1;
    while (numb1 > 0)
    {
        numb1 = numb1 / 10;
        countLenght++;
    }
    return countLenght;
}
int ReverseNumber(int numb, int lenghtNumb)
{
    int result = 0;
    bool negativeValue = true;
    if (numb > 0) negativeValue = false;
    numb = Math.Abs(numb);
    while (numb > 0)
    {

        lenghtNumb--;
        result = result + Convert.ToInt32((numb % 10) * Math.Pow(10, lenghtNumb));
        numb = numb / 10;
    }
    if (negativeValue == false) return result;
    return result * -1;
}

System.Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());
int lenght = LenghtNumber(number);
int reverse = ReverseNumber(number, lenght);
if (number < 10 && number > -10) System.Console.WriteLine($"Вы ввели цифру {number}, а нужно число!");
else if (number == reverse) System.Console.WriteLine($"Ваше число {number} палиндром!");
else System.Console.WriteLine($"Ваше число {number} не палиндром!");


