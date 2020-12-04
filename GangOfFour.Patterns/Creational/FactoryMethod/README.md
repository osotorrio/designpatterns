## Factory Method pattern

### Formal definition

Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/uml_diagram.png)

### Diagram explained

-   there are 2 main actors, **products** and **creators**
-   a **product** is an object we want to use from a creator, for example, we want to call its methods
-   a **creator** is an object which uses the product to do some business operation
-   the **base creator** has 2 responsabilities:
    1. to know how to use a product
    2. to define an interface which allows its subclasses decide which product will be created
-   the **creator subclasses** has 3 responsabilities
    1. implement the parent interface to create products
    2. to know which product has to be created
    3. to know how to created the product because each product could have different initialization requirements

### When to use this pattern?

Use Factory Method to separate product construction code from the code that actually uses the product.

Use Factory Method to extend the use of new products without modifying the core code of the base creator. Simply add a new subclass creator which will create the new products.

_Note: Your framework (or client code) should not know how to create objects, it should know how to use them_

### Application requirements

-   you are working in an application for a bank which has branches in Spain and France at the moment
-   the bank offers only two type of accounts, business and stardard
-   [the application input parameters are](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Client/Application.cs): country code, type of account, customer name and initial amount
-   when a new account is opened [the application must](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/DefaultBranch.cs):

1. open the account with the customer name
2. credit the account so that the balance is not zero

-   by legislation, [accounts opened in France must run a security credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/FrenchBranch.cs) on the customer before to open the account
-   [accounts opened in Spain don't need to run a credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/SpanishBranch.cs)
