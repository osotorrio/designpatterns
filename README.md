# Design Patterns

## Creational Patterns

-   [Abstract Factory](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Creational/AbstractFactory)
    -   Use when your code needs to work with several families of related objects.
    -   Use to add more families of related objects without modifying your code.
    -   Use to be able to decide in runtime which family of related objects will be used.

-   [Builder](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Creational/Builder)
    - Use to separate the construction of a complex object from its representation.
    - Use to create different representations of the same product.
    - Use to avoid multiple constructors configuration for the same object.

-   [Factory Method](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Creational/FactoryMethod)
    -   Use to separate objects construction code from the code that actually uses the objects.
    -   Use to support the addition of new objects to the system without modifying the client code.

-   [Prototype](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Creational/Prototype)
    -   Use when your code needs a copy of an object and you don't want to depend on the concrete classes of the object to be copied.
    -   Use when you have objects with complex initialization requirements. Cloning the object and updating just the properties you need.
    -   Use Prototype Pattern when you have a complex object with several configurations, all of them slightly different.
    -   Use Prototype Pattern when you need to load in memory several independent instances of the same object.

-   [Singleton](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Creational/Singleton)
    -   Use when your code needs an unique single instance of a particular object across your whole system.
    -   Use when you need stricter control over global variables.

## Structural Patterns

-   Adapter
-   Bridge
-   [Composite](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Structural/Composite). Use in a hierarchical structure of objects to treat the same way individual nodes and whole branches of nodes in the tree.
-   Decorator ?!
-   Facade
-   Flyweight
-   Proxy

## Behavioral Patterns

-   Chain of Responsibility ?!
-   Command
-   Interpreter
-   [Iterator](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Behavioral/Iterator). Use to have a common interface to access the items of different type of collections.
-   Mediator ?!
-   Memento
-   [Observer](https://github.com/osotorrio/designpatterns/tree/master/GangOfFour.Patterns/Behavioral/Observer). Use to notify a collection of objects that the internal state of another object has changed
-   State
-   Strategy
-   Template Method
-   Visitor

## General Patters

-   EventAggregator
-   LazyLoad
-   ModelViewViewModel
-   NullObject
-   Repository
-   Rules
-   ServiceLocator
-   Specification
-   UnitOfWork
-   Wrapper

---

Frequency of use (1-5)

-   5 -> Abstract Factory, Factory Method, Facade, Iterator, Observer,
-   4 -> Singleton, Adapter, Composite, Proxy, Command, Strategy,
-   3 -> Prototype, Bridge, Decorator, State, Template Method,
-   2 -> Builder, Chain of Resp., Mediator,
-   1 -> Flyweight, Interpreter, Memento, Visitor
