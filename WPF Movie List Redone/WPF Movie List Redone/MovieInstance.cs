using System;
using System.Collections.Generic;

namespace WPF_Movie_List_Redone
{
    public class MovieInstance
    {
        private string _movieName { get; set; }
        private Genre _movieGenre { get; set; }
        private List<string> _movieActors { get; set; }
        private string _movieRating { get; set; }
        private string _summary { get; set; }
        private DateTime _releaseDate { get; set; }

        private string _publisher { get; set; }
        private string _director { get; set; }
        private ReviewScore _reviewScore { get; set; }


        private int _movieReferenceId { get; }

        public MovieInstance(string movieName)
        {
            _movieName = movieName;
            _movieReferenceId = MovieInstanceController.getNewReferenceId();
        }
    }
}
