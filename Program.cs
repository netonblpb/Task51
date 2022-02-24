//  Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.Clear();
Console.Write("Задайте размер по Х: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте размер по Y: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}