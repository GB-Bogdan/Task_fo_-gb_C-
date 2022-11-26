Console.WriteLine("Введите первое число: ");
Double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Double b = Double.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число a больше числа b");
}
else if (a < b)
{
    Console.WriteLine("Число a меньше числа b");
}
else
{
    Console.WriteLine("Число a равно числу b");
}