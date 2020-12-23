## Prototype Pattern

### Formal definition

Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/Prototype/uml_diagram.png)

### Diagram explained

-   There are 3 main actors, **client**, **prototype** and **concrete prototype**.
-   **concrete prototype** is an object we would like to make a copy of it. After the prototype is copied, or cloned, we will have two identical but independent objects loaded in memory.
-   **abstract prototype** defines a contract for the objects which need to be cloned. This contract is usually one function called clone.
-   The **client** code uses the abstract prototype contract, or interface, to obtain copies of different objects.

### Clues to recognize Abstract Factory pattern

1. **You have an object which complex initialization requirements** which you need to instance in several parts of your system. For instance:
   - An class with 

### When to use this pattern?

### Application requirements
