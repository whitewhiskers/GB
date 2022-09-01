Console.Clear();
System.Console.Write("Введите первую сторону треугольника: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int num2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1)
{System.Console.WriteLine("Такой треугольник может быть");}
else System.Console.WriteLine("Такого треугольника быть не может");