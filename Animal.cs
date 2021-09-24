using System;

namespace AnimalShop
{
    class Animal
    {
        public double Price { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {Type}\nName: {Name}\nPrice: ${Price}");
        }
    }
}
