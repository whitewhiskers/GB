// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
System.Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
double x = 0, y = 0;
if (k1==k2 && b2==b1) 
{
    System.Console.WriteLine("Прямые совпадают");
    return;
}
if (k1==k2)
{
    System.Console.WriteLine("Прямые параллельны");
    return;
}
x = Math.Round((b2-b1)/(k1-k2),2);
y = Math.Round(k1*(b2-b1)/(k1-k2)+b1,2);
System.Console.Write($"Точка пересечения прямых -> ({x}; {y})");
