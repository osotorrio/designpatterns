## Abstract Factory Pattern

### Formal definition

Separate the construction of a complex object from its representation so that the same construction process can create different representations.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/Builder/uml_diagram.png)

### Diagram explained

-   **Products** are objects which have complex configuration construction. They have several properties and multiple ways to combine those properties.
-   **Builders** expose the API and contain the logic to configure products in multiple ways. They know how to construct products.
-   **Directors** encapsulate a predefined logic to use builders to configure products in a specific way which has meaning to business. 

### Clues to recognize Abstract Factory pattern

-   **When you have an object with multiple constructors with many parameters each**.
-   **When you have an object with several representations and/or configurations**.

### Application requirements

-   You are writing an application for a travel agency.
-   The agency sells predefined packages of holidays.
-   At the moment there are only two packages available, standard holiday and VIP holiday packages.
-   You are writing code in the part of the application which has to create summaries of the holiday packages.
-   A holiday package can have two summaries. Price summary and schedule summary.
-   Standard holiday package contains flights, hotel and theme park reservations.
-   Vip holiday package contains flights, hotel, luxury dinner and night club VIP box reservations
