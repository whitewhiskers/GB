System.Console.Write("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
numbers = numbers % 10;
System.Console.WriteLine($"Ваше посленее число трехзначного числа = {numbers}");