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