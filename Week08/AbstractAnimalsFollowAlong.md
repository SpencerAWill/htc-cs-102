# Abstract Classes - Animals
Let's revisit our Animals solution and see if we can improve upon it with abstract classes. Start from the [AbstractClassesIntro](AbstractClassesIntro/AbstractClassesIntro.sln) solution.

## Current `Animal` class
```cs
public class Animal
{
    public int Height
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    public void SayName()
    {
        MessageBox.Show("My name is " + Name);
    }

    public virtual void Speak()
    {
        // Do nothing
    }
}
```

As it stands, the `Animal` class doesn't actually make a lot of sense. A user should never really create a new Animal; they would only want to create _specific_ animals. The `Speak` method cannot be executed for a generic `Animal`; it only makes sense for a specific animal.

## Making the Animal class abstract
The `Animal` class is a good candidate for abstraction because:
- It has some implemented functionality that is shared by its derived classes
- It has some unimplemented functionality that should be implemented by its derived classes
- We do not need to instantiate Animal objects directly

To make the class abstract, use the `abstract` keyword:
```cs
public abstract class Animal
```

Similarly, to make the `Speak` method abstract (and remove its implementation on the base class), use the `abstract` keyword:
```cs
public abstract void Speak();
```

That's it! Now our `Animal` class is abstract.

## Implications
Because our `Animal` class is abstract, we will not be able to instantiate `Animal` objects directly. Instead, we will have to instantiate objects from the derived classes. This is actually beneficial; we **want** to prevent other developers from instantiating `Animal`s, because they do not have a full implementation.

Additional classes inheriting from `Animal` will be **required** to implement the abstract methods. If they do not, they will _also_ be considered abstract. This is also beneficial; we want to prevent other developers from inheriting from the `Animal` class without implementing the `Speak` method.

## Final abstract `Animal` class
```cs
public abstract class Animal
{
    public int Height
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    public void SayName()
    {
        MessageBox.Show("My name is " + Name);
    }

    public abstract void Speak();
}
```