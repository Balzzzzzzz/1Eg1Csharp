// ROZGRZEWKA
// Stwórz tablicę 100 losowych liczb 2-cyfrowych

      Random r =new Random();
      int[] T = new int[100];
      for (int i = 0; i < T.Length; i++)
      {
          T[i] = r.Next(10, 99);
          T[i] = r.Next(10, 31);
      }
      for (int i = 0; i < T.Length; i++)
      {
          Console.Write(T[i] + " ");
      }


// podaj sumę liczb parzystych i ilość liczb nieparzystych
Random r = new Random();
int[] T = new int[100];
int suma = 0;
int nieparz = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 99);
    if (i % 2 == 0) suma += T[i];
    else nieparz += 1;
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}
 Console.WriteLine(" ");
Console.WriteLine("Suma parzystych: " + suma);
Console.WriteLine("Ilość nieparzystych: " + nieparz);


// TABLICE 2-WYMIAROWE
// inicjowanie tablicy


// Zadeklaruj macierz a'la sudoku


// Stwórz losową macierz 4x4 zawerającą dowolne cyfry


//wypełnić macierz 3x5 liczbami dwucyfrowymi korzystając z GetLength()


}
