Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine("Введи правильное число");

void CheckingNumber(string number)
{
    if (number[0]==number[4] & number[1]==number[3])
    {
        Console.WriteLine("Это чило палиндром");
    }
    else Console.WriteLine("Это чило не палиндром");
}
