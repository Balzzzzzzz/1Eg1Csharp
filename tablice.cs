/*Wygeneruj tablicę n losowych liczb:
 * 
Random r = new Random()
r.Next(pocz, kon)
n = 10 w przedziale[1, 20]

1. Znajdź największą liczbę w tablicy \/
2. Znajdź najmniejszą liczbę w tablicy \/
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy 
5. Podaj rozpiętość tablicy (różnica max - min) \/
6.Podaj sumę liczb w tablicy \/
7. Podaj średnią wartość liczb w tablicy \/
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy*/

/*Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1,20);   
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}
}*/


/*Console.WriteLine("Zadanie 1")
 Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] + " ");
    
}
Console.WriteLine("Maksymalna liczba: " + T.Max());*/

/*Console.WriteLine("Zadanie 2")

Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] + " ");

}
Console.WriteLine("Minimalna liczba: " + T.Min());*/

using System.Security.Cryptography.X509Certificates;
/*
Console.WriteLine("Zadanie 3");
Random r = new Random();
int[] T = new int[20];
int maksik = T[0];
int ilosc = 1;
for (int i = 0; i < T.Length; i++)
{
 if (T[0] > maksik)
 { 
    maksik = T[i];
    ilosc = 1;
 }
 else if ( T[i] == maksik)
 {
    ilosc = ilosc + 1;
 }  
}
Console.WriteLine(maksik + "-" + ilosc);
*/

//Console.WriteLine("Zadanie 5")
/*Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] + " ");

}
Console.WriteLine("Maksymalna liczba: " + T.Max());
Console.WriteLine("Minimalna liczba: " + T.Min());
Console.WriteLine("Różnica  min i max: " + (T.Max() - T.Min()));*/


/*Console.WriteLine("Zadanie 6");
Random r = new Random();
int[] T = new int[20];
int suma = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] + " ");
    foreach (int x in T)
    {
        suma = suma + x;
    }

}
Console.WriteLine("Suma tych liczb: " + suma);*/

/*Console.WriteLine("Zadanie 7"); 
Random r = new Random();
int[] T = new int[20];
int suma = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] + " ");
    foreach (int x in T)
    {
        suma = suma + x;
    }

}
Console.WriteLine("Srednia wartość tych liczb: " + (suma / 20));*/


Console.WriteLine("Zadanie 8");
Random r = new Random();
int[] T = new int[20];
int parzyste = 0;
int nieparzyste = 0;
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 20);
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
    if (T[i] % 2 == 0)
    {
        parzyste += 1;
    }
    else if (T[i] % 2 != 0)
    {
        nieparzyste += 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine("Ilość parzystych: " + parzyste);
Console.WriteLine("Ilość nie parzystych: " + nieparzyste);





































