/* 1. (Very Easy) Sprawdź czy wpisany przez użytkownika ciąg 3 liczb jest arytmetyczny / geometryczny /
rosnący / malejący.Ciąg jest arytmetyczny, gdy istnieje stała różnica między wyrazami: np. 3 5 7; 10 25
40; 13 10 7.Ciąg jest geometryczny, gdy istnieje stały iloraz między wyrazami: np. 2 4 8; 5 25 125; 9 3
1; 7 7 7.Pojęcie ciągu rosnącego i malejącego jest oczywiste.
WE: a, b, c
WY: arytmetyczny−T AK/NIE; geometryczny−T AK/NIE; rosnacy−T AK/NIE; malejacy−T AK/NIE
*/
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
// arytmetyczny czy geometryczny
if (b - a == c - b) Console.WriteLine("jest arytmetyczny");
else if (b / a == c / b) Console.WriteLine("jest geometryczny");
if ( a < b) Console.WriteLine("jest rosnacy");
if (a > b) Console.WriteLine("jest malejacy");
*/

/*2. (Easy) Oblicz sumę liczb trzycyfrowych podzielnych przez 8 i niepodzielnych przez 16
WE: -
WY: suma*/
/*int suma = 0;
for (int i = 104; i <= 999; i += 16)
{
    suma += i;
}
Console.WriteLine(suma);
*/

/*
3. (Easy) Oblicz ilość liczb cztrocyfrowych będącymi wielokrotnościami największej liczby dwucyfrowej podzielnej przez 7. Wielokrotność, będącą podstawą rozwiązania tego zadania, znajdź za pomocą pętli.
WE: -
WY: ilosc*/

/*int wielokr = 0;
int k = 0;
int pierwsza_podzielna = 0;
for (int i = 99; i > 9; i--)
{
    if (i % 7 == 0)
    {
        wielokr = i;
        break;
    }
}
Console.Write("Wielokrotnosc: " + wielokr);
for (int i = 1000; i < 1000 + wielokr; i++)
    if (i % wielokr == 0)
    {
        pierwsza_podzielna = i;
        break;
    }
for (int i = pierwsza_podzielna; i <= 9999; i += wielokr)
{
    k++;
}
Console.WriteLine();
Console.Write("Ilosc liczb spelniajacych warunki: " + k);
*/

/*4. (Medium) Oblicz ilość liczb dwucyfrowych, w kórych cyfra dziesiątek jest przynajmniej dwa razy większa
od cyfry jedności
WE: -
WY: ilosc*/

/*int ilosc = 0;
int cd;
int cj;
for (int i = 10; i < 100; i++)
{
    cd = i / 10;
    cj = i % 10;
    if (cd >= 2 * cj)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/
/*
5. (Medium) Oblicz sumę i ilość liczb trzycyfrowych, w których cyfra setek jest większa od sumy cyfr dziesiątek i jedności
WE: -
WY: suma, ilosc*/

/*int ilosc = 0;
int suma = 0;
int cs;
int cd;
int cj;
for (int i = 100; i < 1000; i++)
{
    cs = i / 100;
    cd = i % 100 / 10;
    cj = i % 10;
    if (cs > cd + cj)
    {
        suma += i;
        ilosc++;
    }
}
Console.WriteLine("Ilosc: " + ilosc);
Console.WriteLine("Suma: " + suma);
*/

/*6. (Medium) Oblicz sumę n najmniejszych liczb dwucyfowych podzielnych przez 19
WE: -n
WY: suma*/
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
int i = 1;
while (n > 0)
{
    if (i % 19 == 0)
    {
        suma += i;
        n--;
    }
    i++;
}
Console.WriteLine(suma);*/

/*7. (Medium) Oblicz sumę n największych liczb trzycyfrowych podzielnych przez 37
WE: -n
WY: suma*/

/*int n = int.Parse(Console.ReadLine());
int suma = 0;
int i = 999;
while (n > 0)
{
    if (i % 37 == 0)
    {
        suma += i;
        n--;
    }
    i--;
}
Console.WriteLine(suma);*/

/*8. (Medium) Ciąg skaczący.Oblicz sumę n pierwszych elementów poniższego ciągu:
2 − 5 + 8 − 11 + 14 − 17 + 20 − ...
WE: - n
WY: suma*/
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma = suma + (3 * i - 1) * Convert.ToInt16(Math.Pow(-1, i-1));
}
Console.WriteLine(suma);
*/

/*9. (Medium) Ciąg zakręcony.Oblicz iloczyn n pierwszych elementów poniższego ciągu:
1 ∗ (−2) ∗ 4 ∗ (−8) ∗ 16 ∗ (−32) ∗ ...
WE: -n
WY: iloczyn*/
/*int n = int.Parse(Console.ReadLine());
double iloczyn = 1;
for (int i = 0; i < n; i++)
    iloczyn *= (Math.Pow(2, i) * Math.Pow(-1, i));
Console.WriteLine($"Iloczyn: {iloczyn}");*/

/*10. (Hard) Ciąg siłaczy.Oblicz sumę n pierwszych elementów poniższego ciągu:
1! + 2! + 3! + 4! + 5! + ...
WE: - n
WY: iloczyn
*/
/*
int n = int.Parse(Console.ReadLine());
int suma = 0;
int wynik = 1;
for (int i = 1; i <= n; i++)
{
    wynik = 1;
    for (int j = 1; j <= i; j++)
    {
        wynik = wynik * j;
    }
    suma += wynik;
}
Console.WriteLine(suma);
*/

/*11. (Hard) Ciąg niebanalny1.Napisz program, który obliczy sumę n ułamków następującej postaci
1
1 +
3
4 +
5
9 +
7
16 +
9
25 + ...
WE: n
WY: suma*/
/*int n = int.Parse(Console.ReadLine());
double suma = 0;
for (int i = 1; i <= n; i++)
{
    suma = suma + (2 * i  - 1)/(Math.Pow(i, 2));
}
Console.WriteLine(suma);
*/

/*12. (Hard) Ciąg niebanalny2.Napisz program, który obliczy ułamek n elementów licznika i mianownika następującej postaci
1+3+5+7+9+...
1+4+9+16+25+...
WE: n
WY: suma*/
/*int n = int.Parse(Console.ReadLine());
int licznik = 0;
double mianownik = 0;
for (int i = 1; i <= n; i++)
{
    licznik += i * 2 - 1;
    mianownik += Math.Pow(i, 2);
}
Console.WriteLine($"{licznik}/{mianownik} = {Math.Round(licznik/mianownik, 3)}");*/

/*13. (Hard) Ciąg wymagający.Napisz program, który obliczy sumę n ułamków następującej postaci
2
3 +
4
10 +
6
29 +
8
66 +
10
127 + ...
WE: n
WY: suma*/
/*int n = int.Parse(Console.ReadLine());
double suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += i * 2 / (Math.Pow(i, 3) + 2);
}
Console.WriteLine($"Suma: {Math.Round(suma, 3)}");*/

/*14. (Hard) Ciąg wymagający.Napisz program, który obliczy sumę n ułamków następującej postaci
2
3 +
4
10 +
6
29 +
8
66 +
10
127 + ...
WE: n
WY: suma*/

/*15. (Hard) Ciąg totalny.Napisz program, który obliczy iloczyn n ułamków następującej postaci
3
1
∗
4
3
∗
5
7
∗
6
15 ∗
7
31 ∗ ...
WE: n
WY: iloczyn
*/
/*int n = int.Parse(Console.ReadLine());
double iloczyn = 1;
for (int i = 1; i <= n; i++)
{
    iloczyn *= (2 + i) / (Math.Pow(2, i) - 1);
}
Console.WriteLine($"Iloczyn: {Math.Round(iloczyn, 3)}");*/

/*16. (Hard) Ciąg ekstremalny.Napisz program, który obliczy iloczyn n ułamków następującej postaci
1
1
∗
2
2
∗
3
4
∗
5
8
∗
8
16 ∗
13
32 ...
WE: n
WY: iloczyn*/
/*int n = int.Parse(Console.ReadLine());
double iloczyn = 1;
int licznik;
int a = 1;
int b = 2;
int temp;
for (int i = 0; i < n; i++)
{
    licznik = a;
    iloczyn *= licznik / Math.Pow(2, i);
    temp = b;
    b = temp + a;
    a = temp;
}
Console.WriteLine($"Iloczyn: {Math.Round(iloczyn, 3)}");*/
