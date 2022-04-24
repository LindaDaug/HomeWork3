
using HomeWork3;


//Telefons nokia = new Telefons();

//Console.WriteLine("Lūdzu ievadi telefona izmēru, marku un modeli!");
//string size = Console.ReadLine();
//string brand = Console.ReadLine();
//string model = Console.ReadLine();

//Console.WriteLine($"Apsveicu, Jūs izveidojāt {size} izmēra {brand} {model}");

//nokia.Call();
//nokia.Sms();


//Car bembis = new Car();
//Console.WriteLine("Lūdzu ievadi mašīnas marku, numurzīmi un ātrumu!");
//string carBrand = Console.ReadLine();
//string carNumber = Console.ReadLine();
//string carSpeed = Console.ReadLine();

//Console.WriteLine($"Apsveicu, Jūsu mašīnas marka ir {carBrand}, numurs {carNumber} {carSpeed}");

//bembis.StartToDrive();
//bembis.GoFaster();
//bembis.Stop();
//bembis.Beep();

Product prece = new Product(1, 2, 3, 4);
 
Console.WriteLine("Lūdzu ievadi preces parametrus: garumu, platumu, augstumu un svaru!"); string carBrand = Console.ReadLine();

double preceLenght = double.Parse(Console.ReadLine());
double preceWidth = double.Parse(Console.ReadLine());
double preceHeight = double.Parse(Console.ReadLine());
double preceWeight = double.Parse(Console.ReadLine());


Console.WriteLine($"Jūsu preces parametri garums: {preceLenght}, platums {preceWidth}, augstums  {preceHeight} un svars {preceWeight}!");

prece.CreateProduct();
prece.ShowProduct();











