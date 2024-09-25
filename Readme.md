Interface:
An interface is a contract that classes or structs adhere to. It contains method signatures, properties, or indexers but no implementation.
Any class or struct that implements an interface must provide an implementation for all of its members.

Interfaces play a key role in Dependency Injection by allowing you to pass different implementations of an interface into a class, promoting loose coupling and easing unit testing.
An interface can inherit from another interface.
The IDisposable interface is used to release unmanaged resources such as file handles, database connections, etc. You implement the Dispose() method for cleanup.
