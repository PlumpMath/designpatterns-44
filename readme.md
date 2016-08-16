## Design Patterns Dojo ##
This project was created to refine my knowledge of design patterns. It is based on the Design Pattern Library found on Pluralsight.

### Adapter
Adapters can abstract a make collection non-conforming classes confirm to a common abstraction. Can also be a type of wrapper. 

Example:
- ADO .NET
	- IDataAdapter
		- OdbcDataAdapter
		- OleDbDataAdapter
		- SqlClientDataAdapter
	

### Bridge
A way to connect two abstractions so that the concrete implementations are connected but can be extended independently. Two abstract classes, where one composes of the other.
 "Decouple an abstraction from its implementation so the two can vary independently." (GOF) 

### Builder
Separates the construction of a complex object from its representation so that the same construction process can create different representations. Useful when the order of the method calls to build the object is important.

### Chain of Responsibility
Like a linked list of nodes that propagates a method call until one of the nodes can handles it. Always call the head method and one of the nodes will return the handled result via the chain.

### Command
### Composite
### Decorator
### Event Aggregator
### Facade
### Factories
### Flyweight
### Interpreter
### Iterator
### Lazyload
### MVP
### MVVM
### Mediator
### Memento
### Null Object
### Observer
### Prototype
### Proxy
### Repository
### Rules
### Service Locator
### Singleton
### State
### Strategy
### Template Method
### Unit of Work
### Visitor
