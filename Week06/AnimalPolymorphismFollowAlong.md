# Animal Polymorphism - Follow-Along
Start from the InheritanceIntro solution from the previous lesson. Remember how `Dog`s, `Duck`s, and `Frog`s were all derived from the `Animal` base class.

## Polymorphism
One of the really cool things about inheritance is that in our code, we can treat all _derived_ class objects like their _base_ class. This is because they follow an "is a" relationship, like so:

- A `Dog` **is an** `Animal`
- A `Duck` **is an** `Animal`
- A `Frog` **is an** `Animal`

This means we can have a `List` of `Animal`s that contains `Dog`s, `Duck`s, and `Frog`s! Here's an example:

```cs
// Define a new List of animals
List<Animal> animals = new List<Animal>();

// Define some animals
Frog frog = new Frog(4, "Kermit", false);
Dog dog = new Dog("Muppet", 20, "Rolf");
Duck duck = new Duck(9, "Donald");

// Add the animals to the list
animals.Add(frog);
animals.Add(dog);
animals.Add(duck);

// Loop through the list and call a method on the objects
foreach (Animal a in animals)
{
    a.SayName();
}
```

Originally, in the `SayName_Button_Click` method, we had a list of `Dog` objects. We would not be able to add `Duck`s or `Frog`s to that list, but if we use a `List<Animal>` instead, we are able to add any class that inherits from `Animal`!

Notice how, in the `foreach` loop, each element of the list is an `Animal`. When it calls the `SayName` method, it steps into the `Animal` class definition to execute the code there. Even though we know these elements are specific animals, the code treats them simply as `Animal`s. This is called **Polymorphism**.

There is a good article in the Microsoft documentation about polymorphism in C#: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism

>At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this occurs, the object's declared type is no longer identical to its run-time type.

### Illustrating Polymorphism with a ListView
Make the following updates to add a `ListView` to our application.

In `Animal.cs`, update the `Height` and `Name` fields to be properties instead of simply fields:

```cs
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
```

In `MainWindow.xaml`, remove the dog image and "Speak" buttons, and add a `ListView` named `lvAnimals`:

```xml
<StackPanel>
    <ListView Name="lvAnimals" Height="150px" Margin="0,0,0,10">
        <ListView.View>
            <GridView>
                <GridViewColumn Width="150" Header="Name" DisplayMemberBinding="{Binding Name}"></GridViewColumn>
                <GridViewColumn Width="100" Header="Height" DisplayMemberBinding="{Binding Height}"></GridViewColumn>
            </GridView>
        </ListView.View>
    </ListView>
    <Button Click="SayName_Button_Click">Say Name</Button>
</StackPanel>
```

In `MainWindow.xaml.cs`:
- Create a new field - `public ObservableCollection<Animal> Animals;`
- In the `MainWindow` constructor
    - Initialize the `Animals` collection
    - Create and Add some `Animal` objects
    - Set the `ItemsSource` for the `ListView` to point to the collection

```cs
public ObservableCollection<Animal> Animals;

public MainWindow()
{
    InitializeComponent();
    Animals = new ObservableCollection<Animal>();
    
    // Define some animals
    Frog frog = new Frog(4, "Kermit", false);
    Dog dog = new Dog("Muppet", 20, "Rolf");
    Duck duck = new Duck(9, "Donald");

    // Add the animals to the list
    Animals.Add(frog);
    Animals.Add(dog);
    Animals.Add(duck);
    
    lvAnimals.ItemsSource = Animals;
}
```

- Update the `SayName_Button_Click` method to use the collection

```cs
private void SayName_Button_Click(object sender, RoutedEventArgs e)
{
    // Loop through the list and call a method on the objects
    foreach (Animal a in Animals)
    {
        a.SayName();
    }
}
```

### Doing More with Polymorphism
So far, we've seen the execution of a base class method on objects of the derived class with `SayName`. This method is defined on the base class, so it will work the same way regardless of which specific animal object calls it. But what if we wanted to do something different for each derived class?

Right now, if we tried to call the `Quack` method on every element in the `animals` list, it would fail, because that method is specific to `Duck`s. Similarly, we are unable to call the `Bark` method on every `Animal`, because that is specific to `Dog`s. But really, these methods are performing the same action: Speak. What we really want is to be able to call a `Speak` method on any given `Animal`, and execute code specific to the derived class. We can!

### Virtual Methods and Override
From the Polymorphism artice:
>Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method. Thus in your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.

In our case, we'd like to replace the various "Speak"ing methods (`Bark`, `Quack`, and `Ribbit`) with a _virtual method_ on the base class. Then, in the derived classes, we can _override_ the virtual method so that each class does something different when its called. We can call this new method `Speak`.

Define the `Speak` method on the `Animal ` class, using the `virtual` keyword to make it overrideable. On the `Animal` class, we don't have to put any code in the body of the `Speak` method.

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
        // Do nothing if the animal is not specific
    }
}
```

Now that we have a virtual `Speak` method, we can override it in each of our derived classes! In fact, all we have to do is update our existing "Speak"ing methods. We want to change their name to `Speak`, and add the `override` keyword:

```cs
public class Frog : Animal
{
    public bool IsPoisonous;

    public override void Speak()
    {
        MessageBox.Show("Ribbit");
    }

    public Frog() { }

    public Frog(int height, string name, bool isPoisonous)
    {
        this.Height = height;
        this.Name = name;
        this.IsPoisonous = isPoisonous;
    }
}
```

Do this for each of the derived classes. Now, we are able to call `Speak` on any animal, and it will execute the specific implementation from the derived class.

We can illustrate this by adding a doubleclick event to our `ListView`. When the user doubleclicks a given item in the list, it should call the `Speak` method on the corresponding object. Create the event handler in `MainWindow.xaml.cs`:

```cs
private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
{
    Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
    if (selectedAnimal != null)
    {
        selectedAnimal.Speak();
    }
}
```

and hook it up in `MainWindow.xaml`:

```xml
<ListView Name="lvAnimals" Height="150px" Margin="0,0,0,10" MouseDoubleClick="lvAnimals_MouseDoubleClick">
```

Depending on which row the user clicks, a different override of the `Speak` method will run!