using System;

class Program
{
    static void Main(string[] args)
    {
        //!! Testing inheritance and method overriding
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        genericAnimal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.WriteLine();

        //!! Testing abstract classes and methods
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of Circle: {circle.GetArea()}"); 
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

        Console.ReadKey();
    }
}
