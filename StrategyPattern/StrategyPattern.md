The strategy pattern is where we encapsulate a group of behaviours (family of algorithms) such that, within this family, they are interchangeable. Strategy allows this to vary independently from the clients that use it.
In this example, the Duck class HAS A Quackable and Flyable interface (each of which has a set of classes implementing them). Whenever a duck is created (example, Mallard, Model), it IS-A duck which HAS-A behaviour.

![alt text](https://github.com/nikki30/HeadFirstDesignPatterns/blob/main/StrategyPattern/strategyPattern.png)
