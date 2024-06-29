# C# Console Application Project
@ Author Clement Mensah

This project demonstrates various object-oriented programming concepts in C# through a console application. It includes implementations for inheritance, abstract classes and methods, and interfaces.

## Project Structure

The project consists of the following files:

- `Animal.cs`: Defines the `Animal` base class with a method `MakeSound()`.
- `Dog.cs`: Inherits from `Animal` and overrides `MakeSound()` to bark.
- `Cat.cs`: Inherits from `Animal` and overrides `MakeSound()` to meow.
- `Shape.cs`: Defines the `Shape` abstract class with an abstract method `GetArea()`.
- `Circle.cs`: Inherits from `Shape` and implements `GetArea()` to calculate the area of a circle.
- `Rectangle.cs`: Inherits from `Shape` and implements `GetArea()` to calculate the area of a rectangle.
- `IMovable.cs`: Defines the `IMovable` interface with a method `Move()`.
- `Car.cs`: Implements `IMovable` and defines `Move()` to indicate the car is moving.
- `Bicycle.cs`: Implements `IMovable` and defines `Move()` to indicate the bicycle is moving.
- `Program.cs`: Main entry point of the application where instances of various classes are created and methods are called to demonstrate functionality.

## Concepts Demonstrated

1. **Inheritance and Method Overriding:**
   - Shows how derived classes (`Dog`, `Cat`) inherit from a base class (`Animal`) and override methods (`MakeSound()`).

2. **Abstract Classes and Methods:**
   - Demonstrates the use of abstract classes (`Shape`) and methods (`GetArea()`) to provide common functionality that subclasses (`Circle`, `Rectangle`) must implement.

3. **Interfaces:**
   - Implements an interface (`IMovable`) to define a contract (`Move()`) that multiple classes (`Car`, `Bicycle`) can adhere to.

## How to Use

To run the application:

1. Ensure you have a C# development environment set up (e.g., Visual Studio, Visual Studio Code with .NET SDK).
2. Clone the repository to your local machine.
3. Open the project in your preferred IDE.
4. Build and run the `Program.cs` file to see the output demonstrating the implemented concepts.

## Example Output

- When running `Program.cs`, you will see output demonstrating different sounds made by animals, areas calculated for shapes, and movement messages for vehicles.

## Contributing

Feel free to fork the repository and extend the project with additional features or improvements. Pull requests are welcome!

## License

This project is licensed under the MIT License. See the LICENSE file for more details.
