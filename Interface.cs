// An interface is a contract that classes or structs adhere to. It contains method signatures, properties, or indexers but no implementation.
// Any class or struct that implements an interface must provide an implementation for all of its members.

public interface ICarMake
{
    void CarMake();
}

public class Cars : ICarMake
{
    public void CarMake()
    {
        System.Console.WriteLine("Chevy");
    }
}

// A class can implement multiple interfaces, but it can only inherit from one abstract class.
// An interface cannot contain fields.
// C# doesn't support multiple inheritance of classes, but it allows implementing multiple interfaces.

public interface ICarColor
{
    void CarColor();
}

public interface ICarModel
{
    void CarModel();
}

public class CarsDesign : ICarColor, ICarModel
{
    public void CarColor()
    {
        System.Console.WriteLine("White");
    }

    public void CarModel()
    {
        System.Console.WriteLine("2022");
    }
}

// Interfaces play a key role in Dependency Injection by allowing you to pass different implementations of an interface into a class, promoting loose coupling and easing unit testing.
// An interface can inherit from another interface.
// The IDisposable interface is used to release unmanaged resources such as file handles, database connections, etc. You implement the Dispose() method for cleanup.
