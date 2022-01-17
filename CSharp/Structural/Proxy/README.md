## Proxy Pattern

### Formal definition
 
Provide a surrogate or placeholder for another object to control access to it.


### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/GangOfFour.Patterns/Structural/Proxy/img/uml_diagram.png)


### Diagram explained
- there are three main entities, **subject**, **real subject** and **proxy**
- the client code only knows about the subject object interface
- both, the real client object and the proxy object inheritance from the subject object
- the proxy object knows about the real subject object by composition


### When to use this pattern?

This pattern has multiple uses. In general you can use this pattern anytime you need to replace an object used by some client code without modifying the client code. The reason for replacing the object could be many. For instance:- to add functionality before and/or after calling the real object (like the Decorator Pattern)- also to change the behaviour of the real object without modifying the code of the real object - to control when and how the real object is loaded in memory, for cases where it could be an expensive memory or computation operation- for testing purposes where you might need to replace the behaviour of the real object without implementing the whole object- in general you should think of a proxy as a "smart wrapper" for the real object


### Code example

The code example demonstrates a common problem. Making more testable part of an existing code application which is using a third part library that we cannot modify.