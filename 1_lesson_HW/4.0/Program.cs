Console.WriteLine("Введите количество чисел: ");
int N = int.Parse(Console.ReadLine());
int m = 1;
Console.WriteLine("Четные числа: ");
while (m <= N)
    {
        if (m % 2==1)
        {
            m++;
        }
        else
        {
            Console.WriteLine(m);   
            m++;
        }
    }