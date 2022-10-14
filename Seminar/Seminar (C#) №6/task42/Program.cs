Console.Clear();
System.Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
// int CountBinary(int num)
// {
//     int count = 0;
//     if (num == 0) return 1;
//     while( num > 0)
//     {
//         num = num /2;
//         count++;
//     }   
//     return count;
// }
// int [] Binary(int num, int size)
// {
//     int i = 0;
//     int [] result = new int [size];
//     while(num > 0)
//     {
//         result[i] = num % 2;
//         num = num / 2;
//         i++;
//     }
//     return result;
// }
// int length = CountBinary(number);
// int [] result = Binary(number,length);
// Array.Reverse(result);
// System.Console.Write($"Ваше число {number} в двоичном представлении -> ");
// for (int i = 0; i < result.Length; i++)
// {
//     System.Console.Write(result[i]);
// }

int b = 0, result = 0, c = 1;
for (int i = 1; number != 0; i++)
{
    b = number % 2;
    number = number / 2;
    c = c * 10;
    result = result + b * c;
}
System.Console.WriteLine(result/10);