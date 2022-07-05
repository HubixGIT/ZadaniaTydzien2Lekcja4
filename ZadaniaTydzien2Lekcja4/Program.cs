Console.WriteLine("Zadanie 1 \n");

string imie;
string nazwisko;
int wiek;
char plec;
string pesel;
string numerPracownika;
//************************************************************************************************************
Console.WriteLine("Zadanie 2");

string litera1 = "a";
string litera2 = "b";
string litera3 = "c";

Console.WriteLine(litera3 + litera2 + litera1);
//************************************************************************************************************
Console.WriteLine("Zadanie 3 \nPodaj wymiary prostokąta: ");

Console.WriteLine("Szerokość: ");
string width = Console.ReadLine();
Console.WriteLine("Długość: ");
string length = Console.ReadLine();

double width1;
double length1;
double diagnol;

Double.TryParse(width, out width1);
Double.TryParse(length, out length1);

diagnol = Math.Sqrt(Math.Pow(width1, 2) + Math.Pow(length1, 2));

Console.WriteLine("Przekątna jest równa: " +  diagnol + "\n");
//************************************************************************************************************
Console.WriteLine("Zadanie 4");

int calkowite;
string ciagZnakow;
double wymierne;

calkowite = 10;
ciagZnakow = "Szkoła Dotneta";
wymierne = 12.5;

Console.WriteLine(calkowite +"\n"+ ciagZnakow + "\n" + wymierne + "\n");
//************************************************************************************************************
Console.WriteLine("Zadanie 5 \nPodaj dane osoby: ");
Console.WriteLine("Imie: ");
string name = Console.ReadLine();
Console.WriteLine("Nazwisko: ");
string surName = Console.ReadLine();
Console.WriteLine("Telefon: ");
string telefon = Console.ReadLine();
Console.WriteLine("Email: ");
string email = Console.ReadLine();
Console.WriteLine("Wzrost: ");
string height = Console.ReadLine();
Console.WriteLine("Waga: ");
string weight = Console.ReadLine();




Console.WriteLine(name + "\n" + Double.Parse(height) + "\n" + Double.Parse(weight));





