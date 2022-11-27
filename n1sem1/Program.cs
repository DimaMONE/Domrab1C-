// Нахождение максимального из двух чисел
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine($"Максимальное равно {numA}");
}
else
{
    Console.WriteLine($"Максимальное равно {numB}");
}