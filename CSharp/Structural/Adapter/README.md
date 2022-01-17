## Adapter Pattern

### Formal definition

Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Structural/Adapter/uml_diagram.png)

### Diagram explained

-   **Products** are objects which we would like to use from the client code. These products come in sets or families. A family of products are in some way conceptually related.
-   The **client** code is an object which uses a family of products to do some business logic. We don't want to modify the client code if a new family of products is added in the future.
-   Each **Concrete factory** knows exactly which set of products will make a family. The concrete factory has the responsibility to create that family of products.

### Clues to recognize Abstract Factory pattern

-   **You have a high-level concept or theme which is composed of several objects**. For instance:

    -   An user interface in a mobile phone is composed of different objects like buttons, text boxes, etc.
    -   A house is composed of different objects like windows, doors, walls, etc.

-   **This family of objects, which compose the high-level concept, they share the same contract**. For instance:

    -   A button in an Android application will have the same contract than a button in a iPhone application. Internally they render in different ways.
    -   A door in a mansion have the same contract than a door in an apartment. Internally they could open in different ways.

-   **There are more than one type of family of objects, also called variants or themes**. Or at least, there is the possibility of including more families in the feature.

### Application requirements

-   You are working in an office management application.

-   The company you are creating the application for has at this moment an office in London and another office in New York.

-   You have to write code to manage the onboarding process of a new employee in the company.

-   When a new employee is hired for an office, 3 processes have to be started in the office.

    1. HR department will kickoff the onboarding process.
    2. Purchasing department will buy desk equipment for the new employee.
    3. Security department has to request credential access to the building for the new employee.

-   Each office manages internally each of these processes in different ways. For instance, security department in London office has different internal processes than security department in New York.

-   The application input parameters are an abstract office, employee name and employee's job title.
