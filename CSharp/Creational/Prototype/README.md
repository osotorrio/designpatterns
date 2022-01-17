## Prototype Pattern

### Formal definition

Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/tree/master/CSharp/Creational/Prototype)

### Diagram explained

- **concrete prototype** is an object we would like to make a copy of it. After the prototype is copied, or cloned, we will have two identical but independent objects loaded in memory.
- **abstract prototype** defines a contract for the objects which need to be cloned. This contract is usually one function called clone.
- The **client** code uses the abstract prototype contract, or interface, to obtain copies of different objects.

### Clues to recognize Abstract Factory pattern

- **You need to have several copies** of the same object in memory.

- **You have an object with many properties** which you need to instance several times throughout your application code.

### Application requirements

- You are writing a file management system which it is composed of folders and files.
- Folders can contain several files and other nested folders as well.
- You are asked to write a function that will copy all files from one folder to another.
- After the files are copied, the new files will have a different path value than the original files.
