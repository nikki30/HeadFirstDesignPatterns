This repo follows my journey through the Head First Design Patterns book by O'Reilly. 
Whenever I have a pattern that I learnt, I will update this repo with a folder summarizing it.

## Design principles:
- 1: Identify the aspects of your application that vary and separate them from what stays the same <br />
-> Like, in Strategy patterns, we saw how ducks may have different quack and fly behaviours so separating them out to an interface is key.

- 2: Program to an interface, not an implementation <br />
-> Use polymorphism. Once you know that there are a myriad of ways we can fly/quack, introduce a set of classes around the interface that implement each of the behaviours.
Side note: this allows code re-use.

- 3:Favour composition over inheritance <br />
-> When you expect a HAS-A relationship such as the one between a duck and its flying behaviours, it is better to create a composition (duck HAS-A set of behaviour classes) as opposed to Duck : FlyableBehaviours.