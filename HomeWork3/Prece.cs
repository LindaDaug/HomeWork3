

namespace HomeWork3
{
    public class Product
    {
        public Product(double length, double height, double width, double weight)
        {
            Length = 1;
            Height = 2;
            Width = 3;
            Weight = 4;
        }
        public double Length { get; }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }

        public void CreateProduct ()
        {
            Console.WriteLine("Preces izveidošana");
        }
        public void ShowProduct ()
        {
            Console.WriteLine("Jūsu prece gatava!");
        }
    }
    
}


