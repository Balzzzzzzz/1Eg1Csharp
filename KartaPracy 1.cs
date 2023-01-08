Console.WriteLine("Zadanie 1");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
double sumakw = (Math.Pow(a, 2)) + (Math.Pow(b, 2));
Console.WriteLine("Suma kwadratów tych liczb: " + sumakw);

Console.WriteLine("Zadanie 2");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
int suma = a + b;
double kwsumy = Math.Pow(suma, 2);
Console.WriteLine(" Kwadrat sumy tych liczb: " + kwsumy);

Console.WriteLine("Zadanie 3");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
int ruzn = a - b;
double szruzn = Math.Pow(ruzn, 3);
Console.WriteLine(" Kwadrat sumy tych liczb: " + szruzn);

Console.WriteLine("Zadanie 4");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Wpisz 3 liczbę: ");
int c = int.Parse(Console.ReadLine());
int iloczyn = a * b * c;
Console.WriteLine("Iloczyn tych liczb: " + iloczyn);


Console.WriteLine("Zadanie 5");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
int suma = 2 * (a + b);
double c = suma * 0.20;
Console.WriteLine("20% tej sumy * 2: " + Math.Round(c, 2));

Console.WriteLine("Zadanie 6");
Console.Write("Wpisz cenę brutto: ");
int brutto = int.Parse(Console.ReadLine());
double netto = brutto / 1.23;
Console.WriteLine("Cena netto: " + Math.Round(netto, 2));


Console.WriteLine("Zadanie 7");
Console.Write("Wpisz 1 liczbę: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Wpisz 2 liczbę: ");
int b = int.Parse(Console.ReadLine());
int c = a % b;
Console.WriteLine("Reaszta z dzielenia: " + c);
