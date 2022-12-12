Zadanie 1 


int a = int.Prase(Console.ReadLine());
int b = int.Prase(Console.ReadLine());
int c = int.Prase(Console.ReadLine());

// C. arytmetyczny

if (b - a == c - b) Console.WriteLine("Jest arytmetyczny");
if (b / a == c / b) Console.WriteLine("Jest geometryczny");

Zadanie 2
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    Console.Write(i + " ");
    if (i % 8 == 0 && i % 16 != 0) suma += i;

}
Console.WriteLine(" ");
Console.WriteLine("Suma liczb 3 cyfrowych: " + suma);



Zadanie 3

int podzielnik= 0;
for (int i = 99; i > 9; i++)
{
	if ( i % 7 == 0)
	{
	    podzielnik = i;
		break;
	}
}
Console.WriteLine(podzielnik);

int suma = 0;
for (int j = 100; j < 1000; j++)
{
	if ( j % podzielnik == 0)
	{
		suma += j;
	}
}
Console.WriteLine(suma);


Zadanie 4
int ilosc = 0;
int suma = 0;
int cd = 0;
int cj = 0;
for (int i = 10; i < 100; i++)
{
	Console.Write(i + " ");
	cd = i / 10;
	cj = i % 10;
	if ( cd >= 2 * cj)
	{
		ilosc += 1;
		suma += i;
	}
}
Console.WriteLine(" ");
Console.WriteLine("ilosc: " + ilosc);
Console.WriteLine("Suma: " + suma);


Zadanie 5




Zadanie 8

int suma = 0;
int n = int.Parse(Console.ReadLine());
for(int i = 1 ; i <= n ; i++)
{
 suma = suma + ( (3*I-1) * ( (int)Math.Pow(-1,i-1 )));
}
Console.WriteLine(suma);

Zadanie 11
int suma = 0;
int n = int.Parse(Console.ReadLine());
for(int i = 1 ; i <= n ; i++)
{
 suma = suma + (2*i-1)/Math.Pow(i,2) ;
}
Console.WriteLine(suma);


