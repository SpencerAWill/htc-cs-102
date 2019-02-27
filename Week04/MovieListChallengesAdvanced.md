# Movie List Exercises
## 1. Rotten Tomatoes
Add a field for "Rotten Tomatoes Score" and store that in the Movie object along with the other values.
- The text box and label should be added to the User Interface
- The field should be of type `double` because it represents a percentage
- When field should be initialized within the constructor
- The score should be added to the `ShowDetails` method

## 2. Duplicate Movies
Prevent the user from adding a movie with a title that already exists in the list. If the movie title is a duplicate, show a message to the user saying it cannot be added.

## 3. Error Handling
Add in proper error handling for numeric (`int` and `double`) fields when "Add" is clicked.
- If the user does not enter a number for the numeric fields, display a message to the user saying there was an error, and prevent the movie from being added to the list
- If the movie is added successfully, display a message to the user saying it was added

References:
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
- https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netframework-4.7.2

## 4. CHALLENGE - Release Date
Instead of storing the Release Year for a movie, store the Release Date using a `DateTime` type. Use a `DatePicker` in the User Interface to allow the user to select a date.
- Update the `ReleaseYear` field in the `Movie` class:
    - Change the name to `ReleaseDate`
    - Change the type to `Date`
- Resource: https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.datepicker

## 5. CHALLENGE - Genre Dropdown
Add a field for "Genre" and store that in the Movie object along with the other values.
- The text box and label should be added to the User Interface
- The field should be of type `string`
- When field should be initialized within the constructor
- The genre should be added to the `ShowDetails` method

Use a ComboBox for Genre, allowing the user to select from a dropdown list.
- Resource: https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.combobox

## 6. CHALLENGE - Text file Database
Save/Load the movie list to/from a text file.
- The text file should represent the contents of the movie list in some way
- Add a Save button that exports the contents of the list into the text file
- Add a Load button that loads the list of Movies into memory from the text file
- Resource: https://support.microsoft.com/en-us/help/816149/how-to-read-from-and-write-to-a-text-file-by-using-visual-c
