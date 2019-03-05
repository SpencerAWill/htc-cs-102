using System;
using System.Collections.Generic;
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

namespace WPF_Movie_List_Redone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Genre> allGenres = new List<Genre>() { new Genre("Action"), new Genre("Adventure") };
        List<MovieInstance> allMovies;

        ComboBox genreSelectionComboBox = null;
        Grid editorGrid = null;







        public MainWindow()
        {
            InitializeComponent();
            genreSelectionComboBox = EditorGenreSelectionContainer;
            UIController.addGenreOptions(allGenres, genreSelectionComboBox);
            editorGrid = MovieEditor;
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void NewMovieButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewGenreButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
