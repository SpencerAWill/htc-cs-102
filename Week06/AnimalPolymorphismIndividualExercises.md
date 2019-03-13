# Animal Polymorphism - Individual Exercises
Update the Animal list application to make it more robust.

## Add animal weight
The users of the Animal list application would like to store each animal's weight in addition to the rest of their properties.

1. Create a new integer **property** on the `Animal` class: `Weight`
    - HINT: This should be quite similar to the `Height` property
1. Add a `weight` parameter to each different animal class's constructors
    - `Dog`, `Duck`, and `Frog` should all set the `Weight` property when initializing
    - Update the instantiation of the animal objects in `MainWindow.xaml.cs` with the new parameter
1. In `MainWindow.xaml`, add an additional `GridViewColumn` and bind it to the `Weight` property

Verify that when running the program, the new column appears with the proper values.

## Add new animals to the list
The users would like to fill out the list with some additional animals:

| Type | Name     | Height | Weight |
|------|----------|--------|--------|
| Dog  | Clifford | 200    | 1000   |
| Duck | Daffy    | 5      | 60     |
| Frog | Jeremiah | 3      | 15     |


For each of the animals listed above, in the `MainWindow()` constructor in `MainWindow.xaml.cs`:
1. Instantiate a new animal object
1. Add the object to the `Animals` list

Verify that when running the program, the new animals appear with the proper values.

## New window
When the user clicks a row within the `ListView`, instead of calling the `Speak` method, the program should open a new window with information about the animal. A different type of window should open depending on the type of animal. A picture of the animal should appear within the window, along with the information about the specific animal object that was clicked.