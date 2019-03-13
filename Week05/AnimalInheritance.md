# Dogs and Ducks and Frogs, Oh My
Start from the [InheritanceIntro](InheritanceIntro/InheritanceIntro.sln) solution. Remember how we represented a Dog in C# using the `Dog` class.

## Duck
Next, say we wanted to represent a Duck. Create a new file, `Duck.cs`, and define the Duck class:

```cs
public class Duck
{
    public int Height;
    public string Name;

    public void Quack()
    {
        MessageBox.Show("Quack");
    }

    public void SayName()
    {
        MessageBox.Show("My name is " + Name);
    }

    public Duck() { }

    public Duck(int height, string name)
    {
        this.Height = height;
        this.Name = name;
    }
}
```

After the Duck class is created, add a new button called "Quack" that will create a Duck and call the `Quack` method. Additionally, in the existing method for the "Say Name" button, create a Duck and call the `SayName` method.

## Inheritance
There is a good article in the Microsoft documentation about inheritance in C#: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#background-what-is-inheritance

>Inheritance is one of the fundamental attributes of object-oriented programming. It allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. The class whose members are inherited is called the base class. The class that inherits the members of the base class is called the derived class.

What do each of our Animal classes have in common?
- `Height` Property
- `Name` Property
- `SayName` Method

Rather than repeating these properties and methods in each class, we can create one **Base Class** and have our animals inherit from it! Define the `Animal` class in a new `Animal.cs` file:

```cs
public class Animal
{
    public int Height;
    public string Name;

    public void SayName()
    {
        MessageBox.Show("My name is " + Name);
    }
}
```

Now, we should be able to remove the redundancies from our `Dog` and `Duck` classes. There's just one last thing we need to do: set up our classes to _inherit_ from the `Animal` class. We do this using a colon (`:`) when after our class name:

```cs
public class Dog : Animal
{
    public string Breed;

    public void Bark()
    {
        MessageBox.Show("Bark");
    }

    public Dog() { }

    public Dog(string breed, int height, string name)
    {
        this.Breed = breed;
        this.Height = height;
        this.Name = name;
    }
}
```

>When reading your code, you can think of the colon to mean "is a" or "is an." So, `Dog : Animal` would read "Dog is an Animal", `Duck : Animal` would read "Duck is an Animal", and so on.

Notice that we can still set the `Height` and `Name` properties in the constructor, even though we aren't defining them in the `Dog` class! This is because they are coming from the `Animal` class, and `Dog` inherits from `Animal`.

## Updating Duck
We can do the same thing for our `Duck` class, too. The program should function in the exact same way, but now it's much easier to add another Animal if we want. We can also update the `Animal` class, and all classes that inherit it will receive those updates.