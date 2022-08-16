// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.Clear();
System.Console.WriteLine("Введите координаты точки");
System.Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string CheckQuater(int firstcoordinate, int secondcoordinate)
{
    if (firstcoordinate > 0 && secondcoordinate > 0) return "Первая четверть";
    if (firstcoordinate < 0 && secondcoordinate > 0) return "Вторая четверть";
    if (firstcoordinate < 0 && secondcoordinate < 0) return "Третья четверть";
    if (firstcoordinate > 0 && secondcoordinate < 0) return "Четвертая четверть";
    return "Введены некоректные координаты";
}
string quater = CheckQuater(x, y);
System.Console.WriteLine(quater);