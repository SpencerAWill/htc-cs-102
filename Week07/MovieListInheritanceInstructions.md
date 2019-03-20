# Adding Inheritance to the Movie List Application
Let's augment our Movie List so it can keep track of Animated Movies in a special way. For an animated movie, we want to store the Animation Studio that produced the film, and we want to store the Animation Type (2D or 3D). There should be a way to add Animated Movies, and when an Animated Movie is double clicked from within the `ListView`, it should display the additional information.

Start from `MovieListInheritance.sln`, and then follow the instructions below to complete the exercise.

## The `AnimatedMovie` class
Create a new `AnimatedMovie.cs` file, and define a new class `AnimatedMovie`. The `AnimatedMovie` class should:

- Inherit from the `Movie` class
- Have two `string` properties: `AnimationStudio` and `AnimationType`
- Have a constructor that initializes its four properties: `Title`, `ReleaseYear`, `AnimationStudio`, `AnimationType`
- Override the `ShowDetails` method so that it displays each of the four properties in a nice format
    - Note: to do this, you will have to update the method in the `Movie` class to support overriding

## The Main Window XAML
Currently, the XAML contains a `StackPanel` within a `Border`. That's where we want to add our Animated Movie options! Update the `StackPanel` to include the following:
- A field (`TextBlock` and `TextBox`) for Animation Studio
- A field (`TextBlock` and `TextBox`) for Animation Type
- A `Button` to add an animated movie (it should say "Add Animated Movie")

Make sure the `TextBox`es have `Name`s so we can reference them in the `MainWindow.xaml.cs` file. Also, try to style the fields and button so that they match the existing fields and button. Update the `Margin` and `HorizontalAlignment` as necessary.

## The Main Window C# - Hooking up the Add Animated Movie button
In the Solution Explorer, expand `MainWindow.xaml` and open `MainWindow.xaml.cs`. Within the `MainWindow` class, create a new method with the following signature:

```cs
private void AddAnimatedMovieButton_Click(object sender, RoutedEventArgs e)
{

}
```

Back in the XAML, set the `Click` property of the "Add Animated Movie" `Button` to point to the `AddAnimatedMovieButton_Click` method. Then, in the body of the `AddAnimatedMovieButton_Click` method:
- Get all of the values from the XAML `TextBox`es and store them in variables
- Create a new `AnimatedMovie` object using the values from the `TextBox`es
- Add the `AnimatedMovie` to `MovieList`
- Clear all of the `TextBox`es

## Testing it out
Run your application and make sure it works as intended! You should be able to add an Animated Movie. You should also still be able to add a regular Movie. When an item in the List is clicked, it should show the details. If the item is a regular Movie, it should show the Title and Release Year. If the item is an Animated Movie, it should show the Title, Release Year, Animation Studio, and Animation Type.