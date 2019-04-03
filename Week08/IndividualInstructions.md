# Individual Exercise - Abstract Shapes
In this exercise, you will create some shapes, and add them to a blank WPF window.

## Setup
### New WPF Application
Start by creating a completely new WPF application. Open up Visual Studio and select File -> New -> Project, and choose "WPF Application" from the "Visual C#" menu.

### `MainWindow.xaml` updates
In the XAML file, add a new `Canvas` element inside of the existing `Grid`. Make sure to give it a `Name` so we can use it in the C# code:

```xml
<Canvas Name="myCanvas"></Canvas>
```

Then, update the `Window`'s `Height` and `Width` to give you some additional space.

### `MainWindow.xaml.cs` updates
First, make sure you have the proper `using` statements for all of the namespaces we will be using:
```cs
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
```

Then, within the `MainWindow` method, create a new `Rectangle` object, and set some of its basic properties:
```cs
Rectangle myRect = new Rectangle();
myRect.Height = 100;
myRect.Width = 100;
myRect.Fill = Brushes.Red;
myRect.Stroke = Brushes.Black;
myRect.StrokeThickness = 2;
```

We also want to move the rectangle on the canvas. We can accomplish that with the following code:
```cs
Canvas.SetLeft(myRect, 100);
Canvas.SetTop(myRect, 100);
```

Finally, to actually see our rectangle, we have to add it to our canvas.
```cs
myCanvas.Children.Add(myRect);
```

Now, run the program and make sure you see a rectangle!

## Creating a custom shape - Diamond
To create custom shapes, you can create new classes that inherit from a built-in class called `Shape`. The `Shape` class is an abstract class that contains a lot of the basic functionality for shapes.

### Diamond class
First, create a new file called `Diamond.cs`. Make sure you add the `using` statement for `System.Windows.Shapes` so you have access to the `Shape` base class. Then, define a new class called `Diamond`, and make it inherit from `Shape`.

It should look something like this:

![shape](https://i.imgur.com/TnnfLKE.png)

Notice the red squiggles under `Diamond`. Those are there because our `Diamond` class does not properly implement all of the abstract members of the `Shape` class! To get rid of those, place the cursor over `Diamond` by clicking on it, and then press "`Ctrl`"+"`.`". A menu should appear with an option that says "Implement Abstract Class". Press enter and Visual Studio will fill out a dummy implementation to satisfy the compiler and remove the error! After that, you should have something like this:

```cs
using System;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    public class Diamond : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
```

#### Filling out the `DefiningGeometry` property
.NET uses the `Geometry` class to represent geometric shapes. There are a lot of cool things you can do with the `Geometry` class, but to start, we simply want to draw four lines to make our diamond. Replace the `throw new NotImplementedException();` within the `get` with the following code:

```cs
PathFigure myPathFigure = new PathFigure();
myPathFigure.StartPoint = new Point(50, 0);

LineSegment segment1 = new LineSegment();
segment1.Point = new Point(100, 50);
LineSegment segment2 = new LineSegment();
segment2.Point = new Point(50, 100);
LineSegment segment3 = new LineSegment();
segment3.Point = new Point(0, 50);
LineSegment segment4 = new LineSegment();
segment4.Point = new Point(50, 0);

PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
myPathSegmentCollection.Add(segment1);
myPathSegmentCollection.Add(segment2);
myPathSegmentCollection.Add(segment3);
myPathSegmentCollection.Add(segment4);

myPathFigure.Segments = myPathSegmentCollection;

PathFigureCollection myPathFigureCollection = new PathFigureCollection();
myPathFigureCollection.Add(myPathFigure);

PathGeometry myPathGeometry = new PathGeometry();
myPathGeometry.Figures = myPathFigureCollection;

return myPathGeometry;
```

This may look like a lot of code, but most of it is boiler-plate that would be the same for any polygon. The important pieces are:
- Setting the `StartPoint` of the path figure to `new Point(50,0)`
- Setting the `Point` of the line segments to a variety of points

Here are some definitions:

| Class | Purpose |
|-|-|
| `PathFigure` | Represents a subsection of a geometry, a single connected series of two-dimensional geometric segments |
| `Point` | Represents an x- and y-coordinate pair in two-dimensional space |
| `LineSegment` | Represents a line between one `Point` and another `Point` |
| `PathSegmentCollection` | A collection of segment objects |
| `PathFigureCollection` | A collection of `PathFigure` objects |

For our purposes, the important part is how we define the line segments, and the points between them. For the `Diamond` class, we start in the top middle (50, 0), then move to the middle right (100, 50), then move to the bottom middle (50, 100), then move to the middle left (0, 50), and then finally, move back to the top middle (50, 0). These four line segments create our Diamond shape!

### Drawing it out
At this point, it may be helpful to draw the plane on which the `Diamond` lies. This should make it easier to see where the different points are, and help connect the dots for the shape.

## Adding Diamonds to the Canvas
Now that we have our `Diamond` class defined, we can create diamonds and display them. You can treat them just like the `Rectangle` class, other than setting their `Width` and `Height`. **Make a couple of diamonds with a couple of different colors and positions.**

It's pretty easy to make a new shape! Because `Shape` is an abstract class, we can use all of its useful functionality (`Fill`, `Stroke`, etc) without having to implement it ourselves. All we have to implement is the actual definition of the shape.

## More Diamond updates
### Width and Height
Currently, we are not able to properly set the `Width` and `Height` of our `Diamond` shape. This is because we have hard-coded values for our points using static numbers. Instead of using those numbers for the points (e.g., `50`, `100`), we can use the dimensions inherited from the `Shape` class.

#### Drawing it out
Start by drawing a diamond on paper or on a whiteboard. Try to figure out the points of the diamond based on the diamond's width and height. The coordinates for the points should be dynamic and change depending on the height and width.

#### Implementing it in code
Update the `get` for `DefiningGeometry` of the `Diamond` class so that it uses the `Width` and `Height` properties to determine the points used by the line segments. Once you have updated that, you will have to set the `Width` and the `Height` when creating a `Diamond`, like we did for `Rectangle`.

>Note that using the `Width` and `Height` properties within the `Diamond` class is only possible because the `Shape` class has implemented those properties.

### `Diamond` constructor
Currently, it is necessary to set many properties _after_ creating a `Diamond`. **Create a constructor for `Diamond` that takes in a fill color, stroke color, stroke thickness, width, and height, and sets those properties.**

## More Shapes
### Triangle
Create a new file `Triangle.cs`, and a new class `Triangle` that inherits from `Shape`. Use the same technique as the `Diamond` to create the line segments for the triangle. Make sure to use `Width` and `Height` when deciding the points for the line segments. Once the class is fully defined, add a triangle to the canvas.

#### Right triangle?
Add a new boolean property to the `Triangle` class: `IsRightTriangle`. 

- If this property is `true`, draw the triangle with a 90 degree angle in its bottom left corner. The `Width` property should determine the length of the bottom side, and the `Height` property should determine the length of the left side.
- If this property is `false`, draw the triangle with the top point in between the two bottom points. The `Width` property should still determine the length of the bottom side, but the `Height` property should determine the vertical distance between the top point and the middle of the bottom side.

### Pentagon
Create a new file `Pentagon.cs`, and a new class `Pentagon` that inherits from `Shape`. Fill out the class so that it creates line segments that form a pentagonal shape (5-sides). Add a pentagon to the canvas when the class is fully defined.

### (BONUS) Any-Sided Polyon
>Resource: https://math.stackexchange.com/questions/117164/calculate-coordinates-of-a-regular-polygon

Create a new file `AnySidedPolygon.cs`, and a new class `AnySidedPolygon` that inherits from `Shape`. This class should be able to represent any regular polygon with a given number of sides. **Do not use `Height` and `Width` for this class.** It should have a constructor that takes in the number of sides for the shape, and the radius of the surrounding circle.

E.g., if it is called with `3` for the sides, it should represent a triangle. If it is called with `9` for the sides, it should represent a nonagon, etc. The center of the polygon should be (_r_, _r_), and the distance between the center and all of the points should be _r_ (where _r_ = radius).

This is meant to be fairly challenging. You will have to use some sort of loop to create each new line segment.

### (BONUS) Cube
Use two-dimensional figures to represent a cube. This will require many line segments. It is recommended to draw the shape first, before attempting to represent it in code.

![](http://www.mathaware.org/mam/00/master/essays/dimension/JPG/figure21.jpg)
