// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Clear();
System.Console.Write("Введите номер четверти:");
int number = int.Parse(Console.ReadLine());
string CheckQuater(int numberQueter)
{
    if (numberQueter == 1) return "X положительный Y положительный";
    if (numberQueter == 2) return "X отрицательный Y положительный";
    if (numberQueter == 3) return "X отрицательный Y отрицательный";
    if (numberQueter == 4) return "X положительный Y отрицательный";
    return "Введены некоректные координаты";
}
string quater = CheckQuater(number);
System.Console.WriteLine(quater);