## Factory Method pattern

### Formal definition

Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/uml_diagram.png)

### Diagram explained

-   There are 2 main actors, **products** and **creators**
-   A **product** is an object we would like to use from a creator, for example, we want to call its methods.
-   A **creator** is an object which uses the product to do some business logic. In this case, the creator is the client code we would not want to change if new products are needed in the future.
-   The **base creator** has 2 responsabilities:
    1. To know how to use a product to carry on some business logic.
    2. To define an interface which allows its subclasses decide which product will be created.
-   The **creator subclasses** has 3 responsabilities:
    1. Implement the parent interface to create products.
    2. To know which product has to be created.
    3. To know how to created the product because each product could have different initialization requirements.

### Clues to recognize this pattern

1. **You have a high-level object which use another object to execute some business logic with it**. For instance:
   
   - A warehouse object use a new product object to update the inventory.
   - A logistic object use a truck to ship goods to customers.

2. **There are several different types of objects needed by the hight-level object**. For instance:
   - For a warehouse we could have books, desks, lamps, etc.
   - For a logistic object we could have trucks, ships, planes, etc

3. **All these types of objects have the same contract**. For instance:
   - Books, desks and lamps must have the same public methods used to update the inventory.
   - Trucks, ships and planes must have the same public methods to deliver goods.

### When to use this pattern?

Use Factory Method to separate product construction code from the code that actually uses the product.

Use Factory Method to extend the use of new products without modifying the core code of the base creator. Simply add a new subclass creator which will create the new products.

_Note: Your client code should not know how to create objects, it should know how to use them._

### Application requirements

-   You are working in an application for a bank which has branches in Spain and France at the moment.
-   The bank offers only two type of accounts, business and standard
-   When a new account is requested by a customer [the application must](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/AbstractBranch.cs):

    1. Open the account with the customer name.
    2. Credit the account so that the balance is not zero.

-   By legislation, [accounts opened in France must run a security credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/FrenchBranch.cs) on the customer before to open the account.
-   [Accounts opened in Spain don't need to run a credit check](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Creators/SpanishBranch.cs).

-   [The application input parameters are](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Creational/FactoryMethod/Client/Application.cs): an abstract branch, type of account, customer name and initial amount.
