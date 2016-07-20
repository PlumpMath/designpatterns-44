## Design Patterns Dojo ##
This project was created to refine my knowledge of design patterns. In particularlly, the following design patterns:

### Adapter
Can also be a type of wrapper. Adapters can abstract a make collection non-conforming classes confirm to a common abstraction.

interface IAdapter
	+DoSomething();

class Client
	- IAdapter _adapter;
	
class Adapter
	- Adaptee _adaptee;
	+DoSomething(); // calls _adaptee.DoSomethingElse();
	
class Adaptee
	+DoSomethingElse();

Example:
- ADO .NET
	- IDataAdapter
		- OdbcDataAdapter
		- OleDbDataAdapter
		- SqlClientDataAdapter
	

### Bridge
### Builder
### Chain of Responsibility
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