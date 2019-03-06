# Individual Exercise - Even More Animals
We want our program to be able to represent other animals as well!

## Frogs
One animal we would like to represent in our program is Frogs. We want to create a new class, and add a button that will instantiate a new `Frog` object. 

### Frog class
Create a new file, `Frog.cs`, and define the `Frog` class. The class should:
- Inherit from the `Animal` class
- Have a `Ribbit` method that shows a message box saying "Ribbit"
- Have an additional `IsPoisonous` property
- Have a constructor that takes in its height, its name, and whether or not it is poisonous

### Buttons
Similar to the "Bark" and "Quack" buttons, add in a "Ribbit" button. Additionally, add the Frog to the "Say Name" button click, so that it will show a message with the Frog's name.

## Another Animal
Think of another animal we could represent in our code. Add a new class to represent that animal too! Try to think of some specific properties or methods the animal could have in addition to those provided by the base `Animal` class. Make sure to add buttons for any new methods!

## Organisms
An even more basic classification for Animals is **Organisms**. If we wanted to represent even more organisms in our program, beyond simply Animals, we could introduce a new base class!

- Create another class called `Organism`
    - All `Organism`s should have a DNA Profile, represented as a `string`
- Make `Animal` inherit from `Organism`
    - Now all of our `Animal`s will have a DNA Profile, too!

Now, `Animal` is both a base class AND a derived class. It is the base class to `Dog`, `Frog`, etc, and it is the derived class to `Organism`. This means that a `Dog` is an `Animal`, and a `Dog` is ALSO an `Organism` (because an `Animal` is an `Organism`).

## Tree
Now that we represent organisms in our program, we can create more derived classes. Create a new class named `Tree` that inherits from `Organism`, and give it some properties and methods.

## `Object` class
Read the following article to learn more about the `Object` class in C#: https://docs.microsoft.com/en-us/dotnet/api/system.object?view=netframework-4.7.2

### Overriding the `ToString` method
Read through the following article and then override the `ToString` method on all of your classes: https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?view=netframework-4.7.2#Overriding

## Beyond
What other sorts of things could we represent in C#? The answer is pretty much anything. Try to think of some other types of data, and create some classes, base classes, and derived classes for the data. 
