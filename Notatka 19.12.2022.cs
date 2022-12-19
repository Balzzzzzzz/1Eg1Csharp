Random r = new Random();
Console.WriteLine(r.Next(0,10));

------------------------------------------------------------------------------------------

Random r = new Random();
int[] T = new int[1000];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(0, 10);
    Console.Write(" " + T[i]);
}

------------------------------------------------------------------------------------------


Random r = new Random();
int[] T = new int[30];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(0, 10);
    Console.Write(" " + T[i]);
}

Console.WriteLine("\n\n");
for (int j = 1; j < T.Length; j++)
{
    if (T[29] == T[j - 1])
    {
        Console.WriteLine($"Równe liczby to {T[j]} na pozycjach {j - 1}, {j}");
    }
}




















