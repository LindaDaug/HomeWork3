
using HomeWork3;


Telefons nokia = new Telefons();

Console.WriteLine("Lūdzu ievadi telefona izmēru, marku un modeli!");
string size = Console.ReadLine();
string brand = Console.ReadLine();
string model = Console.ReadLine();

Console.WriteLine($"Apsveicu, Jūs izveidojāt {size} izmēra {brand} {model}");

nokia.Call();
nokia.Sms();

Console.WriteLine();
Console.WriteLine("***************************************");
Console.WriteLine();

Car bembis = new Car();
Console.WriteLine("Lūdzu ievadi mašīnas marku, numurzīmi un ātrumu!");
string carBrand = Console.ReadLine();
string carNumber = Console.ReadLine();
string carSpeed = Console.ReadLine();

Console.WriteLine($"Apsveicu, Jūsu mašīnas marka ir {carBrand}, numurs {carNumber} un ātrums: {carSpeed}");

bembis.StartToDrive();
bembis.GoFaster();
bembis.Stop();
bembis.Beep();

Console.WriteLine();
Console.WriteLine("***************************************");
Console.WriteLine();

Product prece = new Product(1, 2, 3, 4);

Console.WriteLine("Lūdzu ievadi preces parametrus: garumu, platumu, augstumu un svaru!");
int preceLenght = int.Parse(Console.ReadLine());
int preceWidth = int.Parse(Console.ReadLine());
int preceHeight = int.Parse(Console.ReadLine());
int preceWeight = int.Parse(Console.ReadLine());
Console.WriteLine($"Jūsu preces parametri garums: {preceLenght}, platums {preceWidth}, augstums  {preceHeight} un svars {preceWeight}!");

prece.CreateProduct();
prece.ShowProduct();

Console.WriteLine();
Console.WriteLine("***************************************");
Console.WriteLine();

Person man = new Person();

Console.WriteLine("Lūdzu ievadi vārdu, uzvārdu, dzimšanas datumu dd.mm.yyyy?");
string FirstName = Console.ReadLine();
man.FirstName = FirstName;
string LastName = Console.ReadLine();
man.LastName = LastName;
string BirthTimeTxt = Console.ReadLine();
man.BirthTime = DateTime.Parse(BirthTimeTxt);


man.Greeting();
man.GetAge();










