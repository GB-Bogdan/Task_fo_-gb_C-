Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = 0;
int number1 = number/100;
if (number > 1000)
{
    Console.WriteLine("Некорректное значение");
}
else 
{
    second = number1*10 + number % 10;
    Console.WriteLine(second);
}