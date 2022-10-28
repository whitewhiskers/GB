// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

Console.Clear();
System.Console.Write("Введите первую координату первой точки: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату первой точки: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите третью координату первой точки: ");
int z1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите первую координату второй точки: ");
int x2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату второй точки: ");
int y2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите третью координату второй точки: ");
int z2 = int.Parse(Console.ReadLine());
Console.Clear();
System.Console.WriteLine($"Ваши точки ({x1},{y1},{z1}) и ({x2},{y2},{z2})");
double CalculationDistance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Round(Math.Sqrt(Math.Pow(xc2 - xc1, 2) + Math.Pow(yc2 - yc1, 2) + Math.Pow(zc2 - zc1, 2)), 2, MidpointRounding.ToZero);
}
double result = CalculationDistance(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между вашими точками -> {result}");