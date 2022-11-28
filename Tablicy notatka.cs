using System;
class Program
{
    public static void Main(string[] args)
    {
/*   int a = 3;
           int b = 5;
           int c = 6;
           int d = 7;

           int[] T = new int[4];
           T[0] = 3;
           T[1] = 5;
           T[2] = 6;
           T[3] = 7;*/

        /*int[] L = new int[] { 3, 5, 6, 7 };
        for (int i = 0; i < L.Length; i++)
            Console.WriteLine(L[i]);
                */

/*
        int n = int.Parse(Console.ReadLine());
        int[] W = new int[n];
        for (int i = 0; i < n; i++)
        {
            W[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < W.Length; j++)
        {
            Console.WriteLine("Wyświetla: " + W[j] + " ");
        }
*/

        // Stwórz tablicę n liczb wpisanych przez usera. Wypisz ostatnią z nich.
      /*   int n = int.Parse(Console.ReadLine());
        int a = 0;
        int[] W = new int[n];
        for (int i = 0; i < W.Length; i++)
        {
            W[i] = int.Parse(Console.ReadLine());
            a = L[i];
        }
        Console.WriteLine(W[n-1]);
*/
//Stwórz tablicę n liczb wpisanych przez usera. Wpisz sumę tych liczb. 
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += W[i];
}
Console.WriteLine("Suma: " + suma);


//Stwórz tablicę n liczb wpisanych przez usera. Wypisz największą liczbę.
int maksik = int.MinValue;
int n = int.Parse(Console.ReadLine());      
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (W[i] > maksik)
    {
        maksik = W[i];
    }
    
}
Console.WriteLine("MAKSYMALNA LUCZBA: " + maksik );

//Stwórz tablicę n liczb wpisanych przez usera. Wypisz ilość największej liczby.
int maksik = int.MinValue;
int ilosc = 1;
int n = int.Parse(Console.ReadLine());      
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (W[i] > maksik)
    {
        maksik = W[i];
        ilosc = 1;
    }
    else if (W[i] == maksik)
    {
        ilosc += 1;
    }
    
}
Console.WriteLine("Ilość: " + ilosc );

//Stwórz tablicę n liczb wpisanych przez usera.
//Wpisz sumę liczb o parzystych indeksach.

int maksik = int.MinValue;
int ilosc = 1;
int n = int.Parse(Console.ReadLine());      
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if ( W[i] % 2 == 0  )
    {
        Console.WriteLine(W[i]);
    }
    else
    {
            
    }

}
Console.WriteLine( " " );

    }
}

