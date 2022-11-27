// Нахождение максимального из трех
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b || a > c) max = a;
else if (b > c) max = b;
else max = c;
Console.WriteLine($" Максимальное число равно {max} ");