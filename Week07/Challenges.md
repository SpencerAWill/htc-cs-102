# Animated Movie: Challenges
Complete the following challenges after adding animated movies to the Movie List application.

## Handling improper input
Currently, when entering a non-numeric value for the movie's release year and attempting to add it, the application will fail. Fix it so that in this case, the application will show a message to the user saying "Please enter a valid year." Use `try` and `catch` blocks to accomplish this.

## Link to web page
Instead of using a `MessageBox` to show information in the `ShowDetails` methods for the classes, have the program open the Wikipedia page for the given movie. Use the internet to figure out how to do this.

## New windows
Instead of having everything within one window, create new windows for adding a movie and adding an animated movie. The application should work as follows:
- The main window should contain the list view of movies
- The main window should also contain two buttons: "Add Movie" and "Add Animated Movie"
- When those buttons are clicked, they should open the new "Add Movie" windows
- The "Add Movie" windows should contain all fields for the given movie type and allow the user to enter information
- The "Add Movie" windows should contain a button to submit the information
- When submitting a new movie from the "Add Movie" windows, it should be added to the list and displayed in the list view