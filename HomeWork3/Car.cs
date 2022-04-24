

namespace HomeWork3
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Sakam braukšanu");
        }

        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;
        }

        public void Beep()
        {
            Console.WriteLine("Beep beep");
        }

        
        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Apstāšanās");
        }
    }
}

