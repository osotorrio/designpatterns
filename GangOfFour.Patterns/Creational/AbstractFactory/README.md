## Abstract Factory pattern

### Formal definition

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/uml_diagram.png)

### Diagram explained

-   There are 3 main actors, **client**, **factories** and **products**
-   **Products** are objects which we would like to use from the client code. These products come in sets or families. A family of products are in some way conceptually related.
-   The **client** code is an object which uses a family of products to do some buiness logic. We would not like to change the client code if new families of products are added in the future.
-   In general, the only responsability of the **abstract factory** is to define a contract. This contract is used by the client code to obtain the family of products needed to deal with its business operations.
-   Each **Concrete factory** knows exactly which set of products will make a family. The concrete factory has the responsability to create that family of products.

### Theory explained

In this pattern the client code is a high-level concept or theme which is composed of several objects. For instance, an user interface in a mobile phone is composed of different objects like buttons, textboxes, etc.

These objects, even though they are completely different to each other, they still form a family of objects because they are conceptually related.

Normaly there is not only one family of objects. There could be several families of objects. For example, one family of buttons and textboxes for Android phones. Another family of buttons and textboxes for an iPhone. Each family, or variant, has different mechanisms to render in the UI.

These is important, a button for an Android could have the same methods that a button for an iPhone. But internally they will have different ways to render in the specific UI.

The whole point of this pattern is to abstract the client away from the internal specific implementations of the products. The client would know it is using a product, but it would never know how the product is doing its job. This is possible thanks to the abstract factories.

_Note: Your client code should not know how to create objects, it should know how to use them._

### When to use this pattern?

Use Abstract Factory when your code needs to work with serveral families of related objects.

Use Abstract Factory to add more families of related objects without changing your code.

Use Abstract Factory to be able to decide in runtime which familly of related objects will be use.

### Application requirements

-   You are working in an office management application.

-   The company you are creating the application for has at this moment an [office in London](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/LondonOffice.cs) and an [office in New York](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/NewYorkOffice.cs).

-   You have to write code to manage the onboarding process of a new employee in the company.

-   When there is a new employee [3 processes have to be started](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Client/Application.cs).

    1. HR department will kickoff the onboarding process.
    2. Purchasing department will buy desk equipment for the new employee.
    3. Security department has to request credential access to the building for the new employee.

-   Each office manages internally each of these processes in different ways.
