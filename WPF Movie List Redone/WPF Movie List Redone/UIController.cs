using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Collections.ObjectModel;

namespace WPF_Movie_List_Redone
{
    static class UIController
    {
        private static ObservableCollection<Genre> genreDropdownList = new ObservableCollection<Genre>();





        /*
        public static MovieInstance pullMovieEditorValues(Grid editorGrid)
        {
            editorGrid.Children
        }
        */

        public static void addGenreOptions(List<Genre> allGenres, ComboBox genreDropdown)
        {
            
            foreach (var genre in allGenres)
            {
                genreDropdown.Items.Add(genre.getName());
            }
            
        }
    }
}
