namespace lb6
{
    using System;

    // Skapa en basklass "Animal" med gemensamma egenskaper och metoder för alla djur.
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public bool IsWild { get; set; }
        public string Sound { get; set; }

        // Konstruktor för att skapa nya djur med standardvärden.
        public Animal(string name, int age, string species, bool isWild)
        {
            Name = name;
            Age = age;
            Species = species;
            IsWild = isWild;
            Sound = "DefaultSound";
        }

        // Gemensam metod för att alla djur ska kunna göra ett ljud.
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound: {Sound}");
        }
    }

    // Skapa tre olika djurklasser som ärver från "Animal" och implementerar nya egenskaper och metoder.

    // Djurklass 1: Hund
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, bool isWild, string breed) : base(name, age, "Dog", isWild)
        {
            Breed = breed;
            Sound = "Woof!";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Dog barks: {Sound}");
        }

        // Unik metod för hundar.
        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches a ball.");
        }
    }

    // Djurklass 2: Katt
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat(string name, int age, bool isWild, bool isLazy) : base(name, age, "Cat", isWild)
        {
            IsLazy = isLazy;
            Sound = "Meow!";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Cat meows: {Sound}");
        }

        // Unik metod för katter.
        public void ScratchFurniture()
        {
            Console.WriteLine($"{Name} the Cat scratches the furniture.");
        }
    }

    // Djurklass 3: Kanin
    public class Rabbit : Animal
    {
        public string FurColor { get; set; }

        public Rabbit(string name, int age, bool isWild, string furColor) : base(name, age, "Rabbit", isWild)
        {
            FurColor = furColor;
            Sound = "Squeak!";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Rabbit squeaks: {Sound}");
        }

        // Unik metod för kaniner.
        public void Hop()
        {
            Console.WriteLine($"{Name} the Rabbit hops around.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Skapa olika djurinstanser och använd deras metoder för att visa deras beteenden.
            Dog dog = new Dog("Buddy", 3, false, "Bulldog");
            Cat cat = new Cat("Whiskers", 2, false, true);
            Rabbit rabbit = new Rabbit("Fluffy", 1, true, "White");

            Console.WriteLine("Dog:");
            dog.MakeSound();
            dog.Fetch();  // Användning av den unika hundmetoden.

            Console.WriteLine("\nCat:");
            cat.MakeSound();
            cat.ScratchFurniture();  // Användning av den unika kattmetoden.

            Console.WriteLine("\nRabbit:");
            rabbit.MakeSound();
            rabbit.Hop();  // Användning av den unika kaninmetoden.
        }
    }

}