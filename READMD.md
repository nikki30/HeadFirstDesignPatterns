This repo follows my journey through the Head First Design Patterns book by O'Reilly. 
Whenever I have a pattern that I learnt, I will update this repo with a folder summarizing it.

## Design principles:
- 1: Identify the aspects of your application that vary and separate them from what stays the same <br />
-> Like, in Strategy patterns, we saw how ducks may have different quack and fly behaviours so separating them out to an interface is key. <br />
-> Trying to identify which part of the code to encapsulate is important - it will be the part that is common & should be separated out.

- 2: Program to an interface, not an implementation <br />
-> Use polymorphism. Once you know that there are a myriad of ways we can fly/quack, introduce a set of classes around the interface that implement each of the behaviours.
Side note: this allows code re-use. Let's say a weather app has three different displays, which rely on the same update - then with each new display, a new line has to be added to the code which calls the update function. Instead, if we coded to the interface IUpdate and implemented the behaviours that are common to these displays, we would be able to re-use code.

- 3:Favour composition over inheritance <br />
-> When you expect a HAS-A relationship such as the one between a duck and its flying behaviours, it is better to create a composition (duck HAS-A set of behaviour classes) as opposed to Duck : FlyableBehaviours.
