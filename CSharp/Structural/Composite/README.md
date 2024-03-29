## Observer Pattern

### Formal definition
 
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.


### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/CSharp/Structural/Composite/uml_diagram.png)


### Diagram explained
- there are four main entities, **client**, **component**, **composite** and **leaf**
- client knowns about component, but client does not know about composite or leaf objects
- component object is just an abstraction that defines a common operation for composite and leaf objects
- leaf objects cannot have children, leaf objects inherit from component object
- composite objects also inherit from component object, but composite objects, by composition, have children of leaf objects
- think about a **leaf** object like a single node in a tree of objects
- think about a **composite** object like a branch in a tree of objects


### When to use this pattern?

Anytime you have a collection of objects which can be represented as a hierarchical structure. And you need to treat, one single object (**leaf**) or a collections of single of objects (**composite**) the same way. 

*Note: examples of hierarchical structures could be a family (grandfather, father, soon) or employees in a company (director, manager, worker)*

*Note: To treat in the same way all objects in the hierarchical structure means to do an operation in all them without knowing if it is a leaf or a composite*

### Code example

Imagine while working on an training online platform, you are given the task calculate the price of all courses selected by the user. Premises:

- users can buy one single course or multiple courses
- courses could be individual courses
- individual courses could be grouped in bundles
- users can buy single bundle courses or multiple bundle courses
- both, individual courses or bundle courses, can be created in runtime.
