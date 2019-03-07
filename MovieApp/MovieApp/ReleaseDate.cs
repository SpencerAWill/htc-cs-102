using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class ReleaseDate : Tag
    {
        private DateTime _releaseDate;

        public ReleaseDate(DateTime releaseDate)
        {
            _releaseDate = releaseDate;
        }

        public int getYear()
        {
            return _releaseDate.Year;
        }

        public int getMonth()
        {
            return _releaseDate.Month;
        }

        public int getDay()
        {
            return _releaseDate.Day;
        }

        public void setReleaseDate(DateTime releaseDate)
        {
            _releaseDate = releaseDate;
        }


    }
}
