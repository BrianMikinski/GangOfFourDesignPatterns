
# Gang Of Four Design Patterns

Explorations on the classic "Design Patterns" book by Gamma, Helm, Johnson and Vlissides

# Goal

Introduce examples of the three categories of design patterns as outlined by the Gang of Four using concrete examples in C#

# Overview

At some point in ever software engineer's career they will likely come across the the classic software engineering book title "Design Patterns: Elements of Resuable Object-Oriented Software." Written in 1994 by Eric Gamma, Richard Helm, Ralph Johnson and John Vlissides (The Gang of Four), this book is a prescient and wonderful introduction to many concepts and patterns found extensively in many programming languages, frameworks, api's and integration solutions.

Beyond advocating for now common Object Orientated practices such as Inversion of Control (IoC, Dependency Injection, etc), Programming to Interfaces, Object Composition, Object Aggregation (Maybe there's a hint of Domain Driven Design in there?), Polymorphism as well as many other OOD commonalities, Design Patterns broudly presents three *purpose* grouped categories for object orientated design solutions and patterns that fit within each of these categories (taken from wikipedia) -

1) **Creational**
    - **Abstract** factory groups object factories that have a common theme.
    - **Builder** constructs complex objects by separating construction and representation.
    - **Factory** method creates objects without specifying the exact class to create.
    - **Prototype** creates objects by cloning an existing object.
    - **Singleton** restricts object creation for a class to only one instance.
2) **Structural**
    - **Adapter** allows classes with incompatible interfaces to work together by wrapping its own interface around that of an already existing class.
    - **Bridge** decouples an abstraction from its implementation so that the two can vary independently.
    - **Composite** composes zero-or-more similar objects so that they can be manipulated as one object.
    - **Decorator** dynamically adds/overrides behaviour in an existing method of an object.
    - **Facade** provides a simplified interface to a large body of code.
    - **Flyweight** reduces the cost of creating and manipulating a large number of similar objects.
    - **Proxy** provides a placeholder for another object to control access, reduce cost, and reduce complexity.
3) **Behavioral**
    - **Chain of responsibility** delegates commands to a chain of processing objects.
    - **Command** creates objects which encapsulate actions and parameters.
    - **Interpreter** implements a specialized language.
    - **Iterator** accesses the elements of an object sequentially without exposing its underlying representation.
    - **Mediator** allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
    - **Memento** provides the ability to restore an object to its previous state (undo).
    - **Observer** is a publish/subscribe pattern which allows a number of observer objects to see an event.
    - **State** allows an object to alter its behavior when its internal state changes.
    - **Strategy** allows one of a family of algorithms to be selected on-the-fly at runtime.
    - **Template** method defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
    - **Visitor** separates an algorithm from an object structure by moving the hierarchy of methods into one object.

Overtime, some of the patterns have shifted or blurred their initial boundaries but their broad definitions still remain highly applicable today. All software does not need cookie cutter design patterns, knowledge of the classifications and implementations is none the less helpful in solution design.

[Phil Haack](https://haacked.com/archive/2007/12/11/favor-composition-over-inheritance-and-other-pithy-catch-phrases.aspx/) 

> I don’t care that a developer doesn’t favor composition over inheritance in a specific case. I only care that the developer thought it through, had a reason for the decision, wants to improve. The goal is not to bend developers to the will of some specific patterns, but to get them to think about their work and what they are doing



# Resources

- [Wikipedia](https://en.wikipedia.org/wiki/Design_Patterns)
- [Martin Fowler](https://martinfowler.com/bliki/GangOfFour.html)
- [SOLID Design  Principles](https://www.youtube.com/watch?v=agkWYPUcLpg)
- [Phil Haack - Composition over Inheritance and other Pithy Catch Phrases](https://haacked.com/archive/2007/12/11/favor-composition-over-inheritance-and-other-pithy-catch-phrases.aspx/)