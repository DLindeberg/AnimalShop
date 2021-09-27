using System;
using System.Collections.Generic;

namespace AnimalShop
{
    class AnimalShop
    {
        private double money;

        public List<Animal> animalList;
        public AnimalShop()
        {
            animalList = new List<Animal>();
            Dog dog1 = new Dog
            {
                Adult = true,
                Color = "Black",
                Name = "Lasse",
                Price = 800.00,
                Race = "Labrador",
                Type = "Dog"
            };
            Cat cat1 = new Cat
            {
                Adult = true,
                Color = "Grey",
                Name = "Sylvanas",
                Price = 700.00,
                Race = "Scottish fold",
                Type = "Cat"
            };
            Bunny bunny1 = new Bunny
            {
                Adult = false,
                Color = "Grey/blue",
                Name = "Gerd",
                Price = 80.00,
                Race = "Blue Wiener",
                Type = "Bunny"
            };
            animalList.Add(dog1);
            animalList.Add(cat1);
            animalList.Add(bunny1);
        }
        public Animal SellAnimal(string animalType)
        {
            foreach (var animal in animalList)
            {
                if (animal.Type == animalType)
                {
                    money += animal.Price;
                    return animal;
                }
            }
            return null;
        }
        public void ShowMoney()
        {
            Console.WriteLine($"The shop has ${money}\n");
        }
    }
}
