At the core of it, this pattern is about decorating an object, with another object - such that, the item being decorated (Beverage) 
is the same class as the item decorating it (Condiments).

Recursively, while wrapping more and more condiments over the beverage, we are able to compute the final cost.

There are drawbacks such as - this is open to any number of decorators being added. And limitations in that the decorator must be of the same class etc.

Note - IS-A and HAS-A relationships. Here, although it looks like Condiment IS-A Beverage because we are inheriting it; remember that we are doing so in order to do decorate it & that the Condiments HAS-A Beverage that it decorates inside it.
