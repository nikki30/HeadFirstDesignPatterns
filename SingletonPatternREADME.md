
Singleton Pattern - ensures that a class only has one instance and provides a global point of access to it.
This is useful in instances where you want only one instance of a class for threading, registry etc.

How do you do it? 
Create a public class with a private constructor & a private readonly static variable holding the new(ed) up object, 
and a public static method that returns this private obj you initialized.
