Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = 0;
if (number >= 1000)
{
    Console.WriteLine("Некорректное значение");
}
else 
{
    second = number/10 % 10;
    Console.WriteLine(second);
}
