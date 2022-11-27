Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int third = 0;
if (number >= 100)
{
    while(number > 1000)
    {
        number = number/10;
    }
    third = number % 10;
    Console.WriteLine(third);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}