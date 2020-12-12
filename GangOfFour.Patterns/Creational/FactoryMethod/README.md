## Factory Method pattern

### Formal definition

Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/uml_diagram.png)

### Diagram explained

-   There are 2 main actors, **products** and **creators**
-   A **product** is an object we would like to use from a creator, for example, we want to call its methods.
-   A **creator** is an object which uses the product to do some business operations. In this case, the creator is the client code we would not want to change if new products are needed in the future.
-   The **base creator** has 2 responsabilities:
    1. To know how to use a product to crarry on some business logic.
    2. To define an interface which allows its subclasses decide which product will be created.
-   The **creator subclasses** has 3 responsabilities:
    1. Implement the parent interface to create products.
    2. To know which product has to be created.
    3. To know how to created the product because each product could have different initialization requirements.

### Theory explained

You have an object, called base creator, which needs to create another object, called product, to do some operations with it. There could be several different products, but all of them implement the same contract.

This is important, in the Factory Method pattern, all products implement the same interface. Opposite to this is the Abstract Factory pattern, where there are group of family producs with different interfaces.

The problem here is that the product, which ultimately would be used by the base creator, is going to be decided in run-time. For instance, depending on some user's input or some configuration value.

It is also important to notice that the base creator only needs one product object to carry on its business logic. Which one would be used it is going to be decided by the children creators.

### When to use this pattern?

Use Factory Method to separate product construction code from the code that actually uses the product.

Use Factory Method to extend the use of new products without modifying the core code of the base creator. Simply add a new subclass creator which will create the new products.

_Note: Your client code should not know how to create objects, it should know how to use them._

### Application requirements

-   You are working in an application for a bank which has branches in Spain and France at the moment.
-   The bank offers only two type of accounts, business and stardard
-   [The application input parameters are](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Client/Application.cs): country code, type of account, customer name and initial amount.
-   When a new account is opened [the application must](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/DefaultBranch.cs):

1. Open the account with the customer name.
2. Credit the account so that the balance is not zero.

-   By legislation, [accounts opened in France must run a security credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/FrenchBranch.cs) on the customer before to open the account.
-   [Accounts opened in Spain don't need to run a credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/SpanishBranch.cs).
