// Задача 25: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
     result = result * num1;
    }
    return result;
}

int exponent = Exponentiation(number1,number2);
System.Console.WriteLine($"Ваше число {number1} в степени {number2} => {exponent}");