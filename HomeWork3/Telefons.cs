﻿

namespace HomeWork3
{
    public class Telefons
    {
        public double Size { get; set; }
        public string Brand { get; set; }
        public double Model { get; set; }
        public void Call()
        {
        Console.WriteLine("Calling");
        }
        public void Sms()
        {
            Console.WriteLine("Sms");
        }
    }
}
