// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Введите ваше целое положительное число: ");
int number = int.Parse(Console.ReadLine());

int SumNumbers(int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
    {
        res = res + i;
    }
    return res;
}
int result = SumNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");