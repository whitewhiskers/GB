// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру обозначающую день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5 && number < 8) System.Console.Write("Этот день выходной!");
else if (number < 6 && number > 0) System.Console.Write("Этот день не выходной!");
else System.Console.Write("Вы ввели неправильно число!");