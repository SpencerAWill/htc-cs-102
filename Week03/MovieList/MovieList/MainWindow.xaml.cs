using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Movie> movieList;
        


        public MainWindow() //Constructor
        {
            InitializeComponent();
            movieList = new List<Movie>();

        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string movieName = " ";
            int movieReleaseYear = 0;
            
            try
            {
                movieName = textBoxTitle.Text;
            }
            catch (Exception)
            {
                NotifyUser.DisplayMessage("Invalid String Detected");
                ClearTextBoxes(true, false);
            }

            try
            {
                movieReleaseYear = Convert.ToInt32(textBoxReleaseYear.Text);
            }
            catch (Exception)
            {
                NotifyUser.DisplayMessage("Invalid Release Year Detected");
                ClearTextBoxes(false, true);
            }
            

            double movieReviewScore = (movieScoreSlider.Value / movieScoreSlider.Maximum) * 100;
            movieReviewScore = Math.Ceiling(movieReviewScore);




            Movie newMovie = new Movie(movieName, movieReleaseYear, movieReviewScore);






            if (!CheckForRepeats(newMovie, movieList))
            {
                movieList.Add(newMovie);
            } else
            {
                string error = "Duplicate Movie Detected!\nPlease Retry";
                NotifyUser.DisplayError(newMovie, error);
            }





            ClearTextBoxes();
        }

        private void buttonShowAllMovies_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in movieList)
                {
                    MessageBox.Show("Name: " + item.getName() + "\n" + "Release Year: " + item.getReleaseYear() + "\n" + "Rotten Tomatoes Score: " + item.getReviewScore());
                }
            }
            catch (Exception)
            {

                throw;
            }
            ClearTextBoxes();
        }

        private void ClearTextBoxes(bool clearTitle = false, bool clearReleaseYear = false)
        {
            if (clearTitle)
            {
                textBoxTitle.Clear();
            }

            if (clearReleaseYear)
            {
                textBoxReleaseYear.Clear();
            }

            movieScoreSlider.Value = 0;
        }

        

        private bool CheckForRepeats(Movie newMovie, List<Movie> movieList)
        {
            foreach (var item in movieList)
            {
                if (newMovie.getName() == item.getName())
                {
                    return true;
                }
            }
            return false;
        }

        private void PullUserValues()
        {

        }
    }
}
