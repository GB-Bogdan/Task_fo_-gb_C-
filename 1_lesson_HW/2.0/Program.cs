Console.WriteLine("Введите первое число: ");
Double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
Double c = Double.Parse(Console.ReadLine());
Double max = 0;
if (a > max) 
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Максимальное число");
Console.Write(max);