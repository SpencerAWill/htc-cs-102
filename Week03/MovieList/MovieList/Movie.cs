using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {

        private string _name;
        private int _releaseYear;
        private double _reviewScore;


        public Movie(string name, int releaseYear = 0, double reviewScore = 0)
        {
            _name = name;
            _releaseYear = releaseYear;
            _reviewScore = reviewScore;
        }



        public string getName()
        {
            return _name;
        }

        public int getReleaseYear()
        {
            try
            {
                return _releaseYear;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double getReviewScore()
        {
            return _reviewScore;
        }

    }

    
}
