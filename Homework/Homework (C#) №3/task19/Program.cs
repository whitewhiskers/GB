// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Усложнение: принимает на вход любое целое число

Console.Clear();
int LenghtNumber(int numb)
{
    int countLenght = 0;
    numb = Math.Abs(numb);
    if (numb == 0) return 1;
    while (numb > 0)
    {
        numb = numb / 10;
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
string CheckPalindrome(int numb, int reverseNumb)
{
    if (numb < 10 && numb > -10) return $"Вы ввели цифру, а нужно число!";
    if (numb == reverseNumb) return $"Ваше число палиндром!";
    return $"Ваше число не палиндром!";
}
System.Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());
int lenght = LenghtNumber(number);
int reverse = ReverseNumber(number, lenght);
string result1 = CheckPalindrome(number,reverse);
System.Console.WriteLine(result1);
