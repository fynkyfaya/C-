Console.WriteLine("Введите значение y");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение w");
double w = double.Parse(Console.ReadLine());
double a = ((y + 2 * w) * (y + 2 * w) * (y + 2 * w));
double b = (y + 0.75);
double c = Math.Log(Math.E, b);
double res = (a / b);
Console.WriteLine($"{res:F2}");
