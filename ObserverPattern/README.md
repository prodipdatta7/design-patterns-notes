# Observer pattern
- **The Observer Pattern** defines a one-to-many dependency between objects so that all of its dependencies are notified and updated automatically when one object changes state. <br><br> More generally, The Observer Pattern defines a one-to-many relationships between a set of objects.<br> When the state of one object changes, all of its dependents are notified.


## Meet the observer pattern
You know how newspaper or magazine subscriptions work:
1. A newspaper publisher goes into business and begins publishing newspapers.
2. You subscribe to a particular newspaper, and every time there's a new edition it gets delivered to you. As long as you remain a subscriber, you get newspapers.
3. You unsubscribe when you don't want papers anymore, and they stop being delivered.
4. While the publisher remains in business, people, hotels, airlines, and other businesses constantly subscribe and unsubscribe.

## Publisher + Subscribers = Observer Pattern
If you understand newspaper subscriptions, you pretty much understand the Observer Pattern, only we call the publisher the ***SUBJECT*** and the subscribers the ***OBSERVERS***.

## The Power of Loose Coupling
When two objects are loosely coupled, they can interact, but they typically have very little knowledge of each other. The Observer Pattern is a very great example of loose coupling.
Let's walk through all the ways the pattern achieves loose coupling:
- **First, the only thing the subject knows about an observer is that it implements a certain interface (the Observer interface)**. It doesn't need to know the concrete class of the observer, what it does, or anything else about it.
- **We can add new observers at any time.** Because the only thing the subject depends on is a list of objects that implement the Observer interface, we can add new observers whenever we want. In fact, we can replace any observer at runtime with another observer. Likewise, we can remove observers at any time.
- **We never need to modify the subject to add new types of observers**. Let's say we have a new concrete class come along that needs to be an observer. We don't need to make any changes to the subject to accommodate the new class type; all we have to do is implement the Observer interface in the new class and register as an observer. The subject doesn't care; it will deliver notifications to any object that implements the Observer interface.
- **We can reuse subjects or observers independently of each other.** If we have another use for a subject or an observer, we can easily reuse them because the two aren't tightly coupled.
- **Changes to either the subject or an observer will not affect the other.** Because the two are loosely coupled, we are free to make changes to either, as long as the objects still meet their obligations to implement the Subject or Observer interfaces.

***Loosely coupled designs allow us to build flexible Object-Oriented (OO) systems that can handle change because they minimize the interdependency between objects.***

### So, by learning The Observer Patterns, we have added a few things to our Object-Oriented toolbox:
- OO Principles
    - Encapsulate what varies
    - Favor composition over inheritance
    - Program to interface, not implementations
    - Strive for loosely coupled designs between objects that interact
- OO Patterns
    - The Observer Pattern
