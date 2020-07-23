## Observer Pattern

### Formal definition
 
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.


### UML diagram

![Source book: Design Patters, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Structural/Observer/img/uml_diagram.PNG)


### Diagram explained
- there are two main entities, **subject** and **observers**
- a subject knows about observers **by composition**
- an observer knows about the subject **by composition**
- subject **inherit** from an abstract subject
- observers **inherit** from an abstract observer or interface


### When to use this pattern?

Anytime you have a collection of objects or things (**observers**) which need to be notified when another separeted object or thing (**subject**) has changed its **internal state**. 

*Note: by changing internal state we mean the change of the value of any its properties.*


### Code example

Imagine while working on an online shop, you are given the task to notify some customers when the price of a specific product has changes. Premises:

- there are customers that want to buy the product automatically if the price of the product drops
- there are customer that just want to receive an email if the price drops
- automatic buyers wants to buy the product only once
- emailed customers want to get notified all the time
- there could be many products and each customer would choose buy automatically or email notifications depending on the product.
