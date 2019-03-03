using System;
using System.Collections.Generic;

namespace WPF_Movie_List_Redone
{
    public class MovieInstance
    {
        private string _movieName;
        private Genre _movieGenre;
        private List<string> _movieActors;
        private string _movieRating;
        private string _summary;
        private DateTime _releaseDate;

        private string _publisher;
        private string _director;
        private ReviewScore _reviewScore;


        private int _movieReferenceId;

        public MovieInstance(string movieName)
        {
            _movieName = movieName;
            _movieReferenceId = MovieInstanceController.getNewReferenceId();
        }
    }
}
