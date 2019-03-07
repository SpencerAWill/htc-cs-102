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

namespace MovieApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<FilmInstance> filmList = new List<FilmInstance>();
        private int referenceId = 0;
        private List<Tag> allTags = new List<Tag>();

        private ListBox filmContainer;



        public MainWindow()
        {
            InitializeComponent();
            filmContainer = UIFilmContainer;
            
        }

        private void DeleteMovieButton_Click(object sender, RoutedEventArgs e)
        {
            UIRemoveSelectedFilm();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            createNewMovie();
        }

        private void createNewMovie()
        {
            FilmInstance newFilm = new FilmInstance(getNewFilmReferenceId());
            filmList.Add(newFilm);
            UIAddNewFilm(newFilm);
        }

        private int getNewFilmReferenceId()
        {
            referenceId++;
            return referenceId;
        }

        private void UIAddNewFilm(FilmInstance newFilm)
        {
            ListBoxItem filmItem = new ListBoxItem();

            newFilm.attachListBoxItem(filmItem);

            Image previewImage = new Image(); //TODO

            Label title = new Label();
            title.Content = newFilm.getName();

            Label reviewScore = new Label();
            reviewScore.Content = newFilm.getReviewScore().ToString();

            Border border = new Border();

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;

            stackPanel.Children.Add(previewImage);
            stackPanel.Children.Add(title);
            stackPanel.Children.Add(reviewScore);

            border.Child = stackPanel;

            filmItem.Content = border;


            try
            {
                filmContainer.Items.Add(filmItem);
                
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void UIRemoveSelectedFilm()
        {
            
            for (int i = 0; i < filmList.Count; i++)
            {
                FilmInstance film = filmList[i];
                if (film.getListBoxItem().Equals(UIGetSelectedItem()))
                {
                    filmList.RemoveAt(i); //remove from back end
                    filmContainer.Items.Remove(film.getListBoxItem());
                }
            }




            //remove from movie list
            //remove from UI
            
        }

        private ListBoxItem UIGetSelectedItem()
        {
            try
            {
                return filmContainer.SelectedItem as ListBoxItem;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void UIDisplayMovieInfo()
        {

        }







        private void DEVDEBUGShowAllReferenceIDs()
        {
            foreach (var film in filmList)
            {
                MessageBox.Show(film.DEVDEBUGGetReferenceID().ToString() + "::::::" + film.getListBoxItem().ToString());
            }
        }
    }
}
