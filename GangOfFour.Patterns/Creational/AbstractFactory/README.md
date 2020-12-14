## Abstract Factory Pattern

### Formal definition

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/uml_diagram.png)

### Diagram explained

-   There are 3 main actors, **client**, **factories** and **products**
-   **Products** are objects which we would like to use from the client code. These products come in sets or families. A family of products are in some way conceptually related.
-   The **client** code is an object which uses a family of products to do some business logic. We don't want to modify the client code if a new family of products is added in the future.
-   In general, the only responsibility of the **abstract factory** is to define a contract. This contract is used by the client code to obtain the family of products needed to deal with its business logic.
-   Each **Concrete factory** knows exactly which set of products will make a family. The concrete factory has the responsibility to create that family of products.

### Clues to recognize Abstract Factory pattern

1. **You have a high-level concept or theme which is composed of several objects**. For instance:

    - An user interface in a mobile phone is composed of different objects like buttons, text boxes, etc.
    - A house is composed of different objects like windows, doors, walls, etc.

2. **This familly of objects, which compose the high-level concept, they share the same contract**. For instance:

    - A button in an Android application will have the same contract than a button in a iPhone application. Internally they render in different ways.
    - A door in a mansion have the same contract than a door in an appartment. Internally they could open in different ways.

3. **There are more than one type of family of objects, also called variants or themes**. Or at least, there is the possibility of including more families with time. For instance:

    - Type of houses like apartment, condo, colonial, cottage, mediterranean, etc
    - Using Abstract Factory will avoid to change the client code when a new familly or theme is added to the system.

### When to use this pattern?

Use Abstract Factory when your code needs to work with several families of related objects.

Use Abstract Factory to add more families of related objects without modifying your code.

Use Abstract Factory to be able to decide in runtime which family of related objects will be used.

_Note: Your client code should not know how to create objects, it should know how to use them._

### Application requirements

-   You are working in an office management application.

-   The company you are creating the application for has at this moment [an office in London](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/LondonOffice.cs) and another [office in New York](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Factories/NewYorkOffice.cs).

-   You have to write code to manage the onboarding process of a new employee in the company.

-   When a new employee is hired for an office, [3 processes have to be started in the office](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Client/Application.cs).

    1. HR department will kickoff the onboarding process.
    2. Purchasing department will buy desk equipment for the new employee.
    3. Security department has to request credential access to the building for the new employee.

-   Each office manages internally each of these processes in different ways. For instance, [security department in London](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Products/SecurityDepartmentLondon.cs) office has different internal processes than [security department in New York](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Products/SecurityDepartmentNewYork.cs).

-   [The application input parameters are](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/AbstractFactory/Client/Application.cs): an abstract office, employee name and employee's job title.
