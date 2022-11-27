Console.WriteLine("Введите цифру, обозначающую день недели: ");
int daynum = int.Parse(Console.ReadLine());
if (daynum == 6 || daynum == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (daynum < 1 || daynum > 7)
{
    Console.WriteLine("Дней недели 7");
}
  else
{
    Console.WriteLine("Этот день не выходной");
}
