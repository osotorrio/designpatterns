## Singleton Pattern

### Formal definition

Ensure a class only has one instance, and provide a global point of access to it.

### UML diagram

![Source book: Design Patterns, Elements of Reusable Object-Oriented Software](https://github.com/osotorrio/designpatterns/blob/master/CSharp/Creational/Singleton/uml_diagram.png)

### Diagram explained

- A singleton class must have a private constructor.
- A singleton class must expose a static function to get the singleton instance.
- Internally the singleton stores the instance in a private field. This field works like a cache.
- The public static function will return the value of the cache or create a new instance, with the private constructor, if the cache is null.

### Clues to recognize Singleton pattern

- **You have a shared resource in your system which should be created only once**. For instance a data base connection string object.

- **You have a collection of global variables across your system**.

### Application requirements

- You are writing some integration tests against a HTTP API.
- The API endpoints have authentication set up.
- You must get an authentication token before calling any other API endpoints.
- To get the authentication token you must post to an endpoint the email and password.
- All test cases need to use this authentication token.
- To speed up the tests, we would like to get the token once and shared between all test cases.
