Console.WriteLine("Введите числа: ");
double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);