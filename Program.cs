// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите значение R:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение U:");
double y = double.Parse(Console.ReadLine());
double res = (x * y);
Console.WriteLine($"{res:F2}");