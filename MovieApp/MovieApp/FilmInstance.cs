using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MovieApp
{
    public class FilmInstance
    {
        private int _referenceId;
        private string _name { get; set; }
        private List<Tag> _tags { get; }
        private DateTime _releaseYear { get; set; }
        private double _reviewScore;

        private ListBoxItem _UIreferenceItem;

        public FilmInstance(int referenceId)
        {
            _referenceId = referenceId;
            setName();
            setReleaseYear();
            setReviewScore();
        } //ctor

        public void addTag(Tag tag)
        {
            try
            {
                if (!_tags.Contains(tag))
                {
                    _tags.Add(tag);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public List<Tag> getTags()
        {
            return _tags;
        }
        public void removeTag(Tag tag)
        {
            try
            {
                _tags.Remove(tag);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public string getName()
        {
            return _name;
        }
        public void setName(string name = "New Movie")
        {
            _name = name;
        }

        public void setReleaseYear(DateTime date = new DateTime())
        {
            _releaseYear = date;
        }
        public DateTime getReleaseYear()
        {
            return _releaseYear;
        }

        public void setReviewScore(double score = 1, double limit = 10)
        {
            _reviewScore = score / limit;
        }
        public double getReviewScore()
        {
            return _reviewScore * 10;
        }
        

        public void attachListBoxItem(ListBoxItem lbi)
        {
            _UIreferenceItem = lbi;
        }
        public ListBoxItem getListBoxItem()
        {
            return _UIreferenceItem;
        }
        public void detachListBoxItem()
        {
            _UIreferenceItem = null;
        }


        public int DEVDEBUGGetReferenceID()
        {
            return _referenceId;
        }
        
    }
}