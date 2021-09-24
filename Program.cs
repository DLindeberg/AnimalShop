using System;

namespace AnimalShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }
        public static void Menu()
        {
            bool stop = true;
            Console.WriteLine("Welcome to your Animalshop!\n");
            do
            {
                AnimalShop animalShop = new AnimalShop();

                Console.WriteLine("\nWhat would you like to do?\n" +
                    "1. Sell animal\n" +
                    "2. Show stores money\n" +
                    "3. Exit program\n");

                int input;

                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 3)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Pick one animal:");
                        int i = 1;
                        foreach (var animal in animalShop.animalList)
                        {
                            // Shows list of availible animals with a number in front for fallowing submenu functionality
                            Console.WriteLine($"{i}. {animal.Type}");
                            i++;
                        }
                        // I chose the fallowing solution to avoid returning null to prevent crashes.
                        // The method PrintInfo() still returns null if an object.Type of an animal doesn't exist
                        // therefore the feature is still there if someone decides to give the user more freedom
                        int input2;

                        while (!int.TryParse(Console.ReadLine(), out input2) || input2 < 1 || input2 > 3)
                        {
                            Console.WriteLine("Invalid input, please try again.");
                        }
                        switch (input2)
                        
                        {
                            case 1:
                                string animalTypeDog = "Dog";
                                Animal soldAnimalDog = animalShop.SellAnimal(animalTypeDog);
                                Console.WriteLine("\nSuccessfully sold animal:\n");
                                soldAnimalDog.PrintInfo();
                                break;
                            case 2:
                                string animalTypeCat = "Cat";
                                Animal soldAnimalCat = animalShop.SellAnimal(animalTypeCat);
                                Console.WriteLine("\nSuccessfully sold animal:\n");
                                soldAnimalCat.PrintInfo();
                                break;
                            case 3:
                                string animalTypeBunny = "Bunny";
                                Animal soldAnimalBunny = animalShop.SellAnimal(animalTypeBunny);
                                Console.WriteLine("\nSuccessfully sold animal:\n");
                                soldAnimalBunny.PrintInfo();
                                break;
                        }
                        break;
                    case 2:
                        animalShop.ShowMoney();
                        break;
                    case 3:
                        stop = false;
                        break;
                }
            } while (stop == true);
        }
    }
}
