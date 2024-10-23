// Base class
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

// Derived class
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

// Another derived class
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.Speak(); // Output: Dog barks
        myCat.Speak(); // Output: Cat meows
    }
}