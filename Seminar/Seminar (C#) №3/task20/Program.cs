// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A(3,6) B (2,1) -> 5,09
// A(7,-5) B (1,-1) -> 7,21

Console.Clear();
System.Console.Write("Введите первую координату первой точки: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату первой точки: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите первую координату второй точки: ");
int x2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату второй точки: ");
int y2 = int.Parse(Console.ReadLine());

double CalculationDistance(int firstcoord1,int secondcoord1,int firstcoord2,int secondcoord2)
{
    return Math.Round(Math.Sqrt(Math.Pow(firstcoord2-firstcoord1, 2)+ Math.Pow(secondcoord2-secondcoord1,2)),2,MidpointRounding.ToZero);
}

double result = CalculationDistance(x1,y1,x2,y2);
System.Console.WriteLine(result);