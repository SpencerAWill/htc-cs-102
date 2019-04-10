# Individual Exercise - Animating Shapes
Follow the instructions below to create some animations.

## Setup
### New WPF Application
Start by creating a completely new WPF application. Open up Visual Studio and select File -> New -> Project, and choose "WPF Application" from the "Visual C#" menu.

**Make sure you save your WPF application in your GitHub Repo Week09 folder.**

### `MainWindow.xaml` updates
In the XAML file, add a new `Canvas` element inside of the existing `Grid`. Make sure to give it a `Name` so we can use it in the C# code. Additionally, set its background to a color:

```xml
<Canvas Name="myCanvas" Background="AliceBlue"></Canvas>
```

Then, update the `Window`'s `Height` and `Width` to give you some additional space.

### Adding a circle
In the `MainWindow.xaml.cs` file, make sure you have the proper `using` statements for all of the namespaces we will be using:
```cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Input;
```

In the `MainWindow` class, create a new private member that will store an ellipse geometry (circle):
```cs
EllipseGeometry myEllipseGeometry;
```

Then, inside the constructor for `MainWindow`, initialize the ellipse geometry, and add a path to the canvas:
```cs
myEllipseGeometry = new EllipseGeometry();
myEllipseGeometry.Center = new Point(200, 200);
myEllipseGeometry.RadiusX = 20;
myEllipseGeometry.RadiusY = 20;

Path myPath = new Path();
myPath.Fill = Brushes.SkyBlue;
myPath.Data = myEllipseGeometry;

myCanvas.Children.Add(myPath);
```

### Animating the circle
Next, we want to make it so that clicking anywhere on the background of the window will move the circle to that location.

In the XAML, add a `MouseLeftButtonDown` property and create a new event handler: `myCanvas_MouseLeftButtonDown`

In the `MainWindow` class, fill out the `myCanvas_MouseLeftButtonDown` method to use a `PointAnimation` that moves the ellipse geometry:
```cs
PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(1));
myEllipseGeometry.BeginAnimation(EllipseGeometry.CenterProperty, myPointAnimation);
```

`e.GetPosition(this)` gets the point of the click on the background. `TimeSpan.FromSeconds(1)` specifies that the animation should take one second. `BeginAnimation` applies the animation to the center property of the ellipse geometry.

Run the program to see the the animation in action!

## Easing Functions
Currently, the circle will move from one point to another in a linear speed. However, it is possible to specify the way the circle moves using an Easing function.

Set the `EasingFunction` property to ease in a circlular speed:
```cs
myPointAnimation.EasingFunction = new CircleEase();
```

Load up the program again to see how the circle's movement changes.

### A Square Easing Function
There are some easing functions already built in to .NET, but we can also define our own thanks to interfaces. All we have to do is create a new class and implement the `IEasingFunction` interface! The `Ease` function for the interface takes in a `double` from 0-1 (representing time), and returns a position in the animation. For example, the linear function would simply return the argument it is given. But we can make the animation move however we want!

Create a new file, `SquareEase.cs`, and create a class that implements `IEasingFunction`. Remember, implementing an interface looks just like inheriting from a class; use `:` followed by the name of the interface. Then, click on the class name, and press `Ctrl`+`.`. This will allow you to quickly implement the interface!

In the `Ease` function, return the argument given multiplied by itself. This way, it will start slowly, and then speed up towards the end in a parabolic trajectory. It looks like this:

![Parabola](https://i.imgur.com/NLLYazL.png)

>Note: This is not the path the movement will take, but the speed. The circle will still move in a straight line, but it will start slowly and then accelerate.

Set the `EasingFunction` for the `PointAnimation` so that it uses the new `SquareEase` class. We can use our new class because it is an `IEasingFunction`!

### A Slow-Fast Easing Function
To make a new type of easing function, we have to create a new class and implement `IEasingFunction` again.

Create a new file, `SlowFastEase.cs`, and create a class called `SlowFastEase`. Implement the `IEasingFunction` interface. In the `Ease` function, make it so that if the normalized time argument is under `.75`, the value returned is the argument divided by 5. Otherwise, return `3.4 * normalizedTime - 2.4`. Note that this is like a piecewise-function: it specifies a continuous movement from 0-1. It will look like this:

![Piecewise](https://i.imgur.com/srzOqvn.png)

Set the `EasingFunction` for the `PointAnimation` so that it uses the new `SlowFastEase` class.

### Other Built-In IEasingFunction types
Though we can make our own easing function implementations, there are a good number that already exist: https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/easing-functions

Check out `BounceEase` and `ElasticEase` for some interesting ones!

## Setting the Easing Function Dynamically
Instead of hard-coding an Easing Function for the animation, it would be cool to have a few buttons on the page that would allow the _user_ to select the Easing Function.

- Create a new field on the `MainWindow` class to store an `IEasingFunction`
- In the `myCanvas_MouseLeftButtonDown`, set the `EasingFunction` for the `PointAnimation` to whatever is stored in the field
- Create at least three buttons in the XAML that will set the value of the field to another easing function

Once complete, test out your program. You should be able to click the buttons, and then click around to see the different easing functions in action!

## Updating an Easing Function
One of the cool things about creating our own `IEasingFunction` classes is that we can make them do whatever we want. We can add methods, properties, and constructors just like any other class!

- For the `SlowFastEase` class, add a new `double` property called `SlowTime`
    - This will determine the time at which the animation flips from slow to fast
- Create a new constructor for the class that sets the `SlowTime` property with the value of a parameter
- In the `Ease` method, update the code so that instead of flipping from slow to fast at `.75`, it does so at `SlowTime`
- Adjust the equation so that it accelerates to the proper speed, and reaches (1, 1) continuously
- You will need to do some math like this: http://www.coolmath.com/algebra/08-lines/12-finding-equation-two-points-01
- For example, if the user wants `SlowTime` to be `.6`:
    - The two points will be `(1, 1)`, and `(0.6, 0.6/5)`
    - The slope will be:
        - `(1-(0.6/5))/(1-0.6)`
        - `.(1-0.12)/0.4`
        - `0.88/0.4`
        - `2.2`
    - The y-intercept will be:
        - `1 = (2.2)(1) + b`
        - `b = 1 - 2.2`
        - `b = -1.2`
    - The full equation will be `2.2x - 1.2`
- Your `Ease` function should be able to properly handle any `SlowTime` between 0 and 1

Now, you can try out different `SlowFastEase` objects with varying `SlowTime`s! The beauty here is that we can specify different animations with one `IEasingFunction` class, because interfaces allow for that flexibility. Add a couple more buttons that will set the easing function to `SlowFastEase` with different `SlowTime` values.

## Another Ellipse
Add another ellipse to the canvas, with a different color and size. It should behave similarly to the first ellipse, but should move with a different easing function. It should also move to a different position, instead of directly where the mouse clicked.

## More Animations
Try to animate some additional shapes with different types of easing functions. Try to make some of the animations trigger on different key presses. Note that animating other types of shapes will not work like ellipses; not all shapes have a `Center` property. Try to find other ways to animate the additional shapes!

## Resources
- https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/easing-functions
- http://www.coolmath.com/algebra/08-lines/12-finding-equation-two-points-01
- https://www.desmos.com/calculator
- http://gizma.com/easing/#quad1
- https://stackoverflow.com/questions/9349930/how-to-draw-a-circle-and-move-it-as-an-animation-in-c-sharp-wpf
