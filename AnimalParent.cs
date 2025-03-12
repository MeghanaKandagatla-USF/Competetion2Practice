using System;

public class Animal  
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Speak() 
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
public class Dog : Animal
{
    public string legs { get; set; }
    public Dog(string noOfLegs) : base(name)
    {
        legs = noOfLegs;
    }
    public override void Speak()
    {
        Console.WriteLine($"{Name} has {legs} Legs.");
    }
}

public class Cat : Animal  // Child class 2
{
    public Cat(string name) : base(name)
    {
    }

    public override void Speak()  // Override the Speak method
    {
        Console.WriteLine($"{Name} meows.");
    }
}
class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");

        dog.Speak();  // Calls Dog's Speak method
        cat.Speak();  // Calls Cat's Speak method

    }
}