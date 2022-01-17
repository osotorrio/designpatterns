## Iterator Pattern

### Formal definition
 
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.


### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/CSharp/Behavioral/Iterator/uml_diagram.png)


### Diagram explained
- there are two main entities, **aggregate** and **iterator**
- an aggregate is an object that wraps a collection of objects
- an iterator is an object that defines how to access the items in the aggreate
- an iterator knows about an aggregate by composition
- an aggregate knows how to create an iterator
- the client code only knows about the abstract aggregate and the iterator interface
- the client code does not know about concrete aggregates or iterator specific implemenation


### When to use this pattern?

Use this pattern to have a common way to access the elements of different type of collections.

*Note: Iterator patter is use in .NET Framework in multiple type of collections*


### Code example

The code example demostrate how to access in the same way two different type of collections such as ArrayList and LinkedList.
In this example we store names of chess players in two different type of collections. But when we loop through both collections there are
not differences in how they are used.
