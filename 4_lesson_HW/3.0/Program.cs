int size = 8;
int[] array = new int[8];
Random arrRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = arrRandom.Next(0,8);
    Console.Write($"{array[i]},");
}