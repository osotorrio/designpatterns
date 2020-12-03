## Factory Method Pattern

### Formal definition
 
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.


### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/uml_diagram.png)


### Diagram explained
- there are two main entities, **products** and **creators**
- a product **inherit** from an abstract product
- an creator **inherit** from an abstract creator
- a concrete creator knows about a specific group of concrete products


### When to use this pattern?

Use this pattern to delegate out of your framework the responsibility of instantiating objects.

*Note: Your framework (or client code) should not know how to create objects, it should know how to use them*


### Application requirements

Imagine you are writting some code for a printer. This printer print out banknotes from different countries.

- the user of the printer would select the currency country which would like to print out the money for.
- once the user has choosen the currency code, the printer will print out all type of banknotes for this country.
