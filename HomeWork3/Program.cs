// See https://aka.ms/new-console-template for more information
using HomeWork3;


Telefons nokia = new Telefons();
Console.WriteLine("Enter size, brand, model");
string size = Console.ReadLine();
string brand = Console.ReadLine();
string model = Console.ReadLine();

nokia.Size = 10;
nokia.Brand = "Nokia";
nokia.Model = 45.00;

Console.WriteLine($"Apsveicu, Jūs izveidojāt {nokia.Size} izmēra {nokia.Brand} {nokia.Model}");