## Abstract Factory pattern

### Formal definition

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/uml_diagram.png)

### Diagram explained

-   There are 3 main actors, **client**, **factories** and **products**
-   **Products** are objects which we would like to use from the client code. These products come in sets or families. A family of products are in some way conceptually related.
-   The **client** code is an object which uses a family of products to do some business logic. We don't not like to modify the client code if a new family of products is added in the future.
-   In general, the only responsibility of the **abstract factory** is to define a contract. This contract is used by the client code to obtain the family of products needed to deal with its business operations.
-   Each **Concrete factory** knows exactly which set of products will make a family. The concrete factory has the responsibility to create that family of products.

### Clues to recognize this pattern

In this pattern you would have a high-level concept or theme which is composed of several objects. For instance, an user interface in a mobile phone is composed of different objects like buttons, text boxes, etc. A house is composed of different objects like windows, doors, walls, etc.

These objects which compose the high-level concept, even though they are completely different to each other, they still form a family of objects because they are conceptually related.

Most probably it would be more than one family of objects. Or at least, the possibility of including more families in the future. For example, one family of buttons and text boxes for Android phones. Another family of buttons and text boxes for an iPhone. Each family, or variant, has different mechanisms to render in the UI.

This is important, a button for an Android could have the same methods that a button for an iPhone, they share the same contract. But internally they will have different ways to render in the specific UI.

### When to use this pattern?

Use Abstract Factory when your code needs to work with several families of related objects.

Use Abstract Factory to add more families of related objects without modifying your code.

Use Abstract Factory to be able to decide in runtime which family of related objects will be used.

_Note: Your client code should not know how to create objects, it should know how to use them._

### Application requirements

-   You are working in an office management application.

-   The company you are creating the application for has at this moment [an office in London](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/LondonOffice.cs) and another [office in New York](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/NewYorkOffice.cs).

-   You have to write code to manage the onboarding process of a new employee in the company.

-   When a new employee is hired, [3 processes have to be started in each office](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Client/Application.cs).

    1. HR department will kickoff the onboarding process.
    2. Purchasing department will buy desk equipment for the new employee.
    3. Security department has to request credential access to the building for the new employee.

-   Each office manages internally each of these processes in different ways. For instance, [security department in London](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Products/SecurityDepartmentLondon.cs) office has different internal processes than [security department in New York](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Products/SecurityDepartmentNewYork.cs).

-   [The application input parameters are](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Client/Application.cs): an abstract office, employee name and employee job title.
